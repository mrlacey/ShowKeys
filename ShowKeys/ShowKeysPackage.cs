// <copyright file="ShowKeysPackage.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace ShowKeys
{
    [ProvideAutoLoad(Microsoft.VisualStudio.Shell.Interop.UIContextGuids.SolutionHasMultipleProjects, PackageAutoLoadFlags.BackgroundLoad)]
    [ProvideAutoLoad(Microsoft.VisualStudio.Shell.Interop.UIContextGuids.SolutionHasSingleProject, PackageAutoLoadFlags.BackgroundLoad)]
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(ShowKeysPackage.PackageGuidString)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideOptionPage(typeof(OptionPageGrid), "Show Keys", "General", 0, 0, true)]
    [ProvideProfileAttribute(typeof(OptionPageGrid), "Show Keys", "General", 106, 107, isToolsOptionPage: true, DescriptionResourceID = 108)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class ShowKeysPackage : AsyncPackage
    {
        public const string PackageGuidString = "03e205da-2ec4-4794-b66f-c6f1f09d17a0";

#pragma warning disable SA1401 // Fields should be private
        public static ShowKeysPackage Instance { get; private set; }
#pragma warning restore SA1401 // Fields should be private

        public OptionPageGrid Options
        {
            get
            {
                return (OptionPageGrid)this.GetDialogPage(typeof(OptionPageGrid));
            }
        }

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);

            Instance = this;

            await ToggleIfEnabledCommand.InitializeAsync(this).ConfigureAwait(false);
            await OptionsCommand.InitializeAsync(this).ConfigureAwait(false);
        }
    }
}
