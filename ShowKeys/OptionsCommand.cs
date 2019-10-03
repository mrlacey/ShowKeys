// <copyright file="OptionsCommand.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace ShowKeys
{
    public sealed class OptionsCommand
    {
        public const int CommandId = 0x0101;

        public static readonly Guid CommandSet = new Guid("b5f24a35-a66a-447f-8d56-d53b6fc8f3dc");

        private readonly AsyncPackage package;

        private OptionsCommand(AsyncPackage package, OleMenuCommandService commandService)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new MenuCommand(this.Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }

        public static OptionsCommand Instance
        {
            get;
            private set;
        }

        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in OptionsCommand's constructor requires
            // the UI thread.
#pragma warning disable CA1062 // Validate arguments of public methods
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);
#pragma warning restore CA1062 // Validate arguments of public methods

            OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)).ConfigureAwait(true) as OleMenuCommandService;
            Instance = new OptionsCommand(package, commandService);
        }

        private void Execute(object sender, EventArgs e)
        {
            this.package.ShowOptionPage(typeof(OptionPageGrid));
        }
    }
}
