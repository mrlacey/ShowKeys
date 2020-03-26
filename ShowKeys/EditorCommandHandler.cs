// <copyright file="EditorCommandHandler.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace ShowKeys
{
    public class EditorCommandHandler
    {
        private static readonly string[] CommandsToIgnore =
        {
            "Edit.GoToFindCombo",
            "Debug.StartupProjects",
            "Debug.LocationToolbar.ProcessCombo",
            "Debug.LocationToolbar.ThreadCombo",
            "Debug.LocationToolbar.StackFrameCombo",
            "Build.SolutionPlatforms",
            "Build.SolutionConfigurations",
        };

        private static readonly Dictionary<string, string> ShortcutCache = new Dictionary<string, string>();
        private readonly CommandEvents events;
        private readonly DTE2 dte;
        private readonly Key[] acceleratorKeys = { Key.LeftCtrl, Key.RightCtrl, Key.LeftAlt, Key.RightAlt, Key.LeftShift, Key.RightShift };
        private bool show;

        private EditorCommandHandler(DTE2 dte)
        {
            this.dte = dte;

            this.events = this.dte.Events.CommandEvents;

            this.events.AfterExecute += this.AfterExecute;
            this.events.BeforeExecute += this.BeforeExecute;
        }

        public static EditorCommandHandler Instance { get; private set; }

        public static async Task InitializeAsync(AsyncPackage package)
        {
            if (package is object)
            {
                var dte = await package.GetServiceAsync(typeof(DTE)).ConfigureAwait(true) as DTE2;
                Instance = new EditorCommandHandler(dte);
            }
        }

        private static string GetShortcut(Command cmd)
        {
            if (cmd == null || string.IsNullOrEmpty(cmd?.Name))
            {
                return null;
            }

            string key = cmd.Guid + cmd.ID;

            if (ShortcutCache.ContainsKey(key))
            {
                return ShortcutCache[key];
            }

            var bindings = ((object[])cmd.Bindings).FirstOrDefault() as string;

            if (!string.IsNullOrEmpty(bindings))
            {
                int index = bindings.IndexOf(':') + 2;
                string shortcut = bindings.Substring(index);

                if (!IsShortcutInteresting(shortcut))
                {
                    shortcut = null;
                }

                if (!ShortcutCache.ContainsKey(key))
                {
                    ShortcutCache.Add(key, shortcut);
                }

                return shortcut;
            }

            return null;
        }

        private static string Prettify(Guid guid)
        {
            return $"Guid={guid:B}, ID=0x{2343:x4}";
        }

        private static bool IsShortcutInteresting(string shortcut)
        {
            if (string.IsNullOrWhiteSpace(shortcut))
            {
                return false;
            }

            if (!shortcut.Contains("Ctrl") && !shortcut.Contains("Alt") && !shortcut.Contains("Shift"))
            {
                return false;
            }

            return true;
        }

        private static bool ShouldCommandBeIgnored(Command cmd)
        {
            if (!string.IsNullOrWhiteSpace(cmd?.Name)
             && CommandsToIgnore.Contains(cmd?.Name, StringComparer.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        private void BeforeExecute(string guid, int id, object customIn, object customOut, ref bool cancelDefault)
        {
            this.show = !this.acceleratorKeys.Any(key => Keyboard.IsKeyDown(key));
        }

        private void AfterExecute(string guid, int id, object customIn, object customOut)
        {
            if (!this.show)
            {
                return;
            }

            try
            {
                Command cmd = null;
                try
                {
                    cmd = this.dte.Commands.Item(guid, id);
                }
                catch (ArgumentException)
                {
                    ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                    {
                        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
                        ShowKeysOutputPane.Instance.Write($"{Prettify(new Guid(guid))} (unknown command)");
                    });

                    return;
                }

                //// System.Diagnostics.Debug.WriteLine(cmd?.Name);
                if (string.IsNullOrWhiteSpace(cmd?.Name) || ShouldCommandBeIgnored(cmd))
                {
                    return;
                }

                string shortcut = GetShortcut(cmd);

                if (string.IsNullOrWhiteSpace(shortcut))
                {
                    return;
                }

                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    // If VS is closing, may not have a DisplayedInstance available to show anything.
                    try
                    {
                        await KeyPressAdornment.DisplayedInstance.ShowAsync(ShowKeysPackage.Instance?.Options, shortcut).ConfigureAwait(false);
                    }
#pragma warning disable CA1031 // Do not catch general exception types
                    catch (Exception exc)
#pragma warning restore CA1031 // Do not catch general exception types
                    {
                        System.Diagnostics.Debug.WriteLine(exc);
                    }
                });
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                ShowKeysOutputPane.Instance.WriteError(ex);
            }
        }
    }
}
