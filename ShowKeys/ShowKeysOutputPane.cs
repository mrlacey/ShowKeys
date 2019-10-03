// <copyright file="ShowKeysOutputPane.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace ShowKeys
{
    public class ShowKeysOutputPane
    {
        private static Guid skPaneGuid = new Guid("9D3267E7-EDE3-462E-9B89-D6806D12618F");

        private static ShowKeysOutputPane instance;

        private readonly IVsOutputWindowPane wmPane;

        private ShowKeysOutputPane()
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            if (ServiceProvider.GlobalProvider.GetService(typeof(SVsOutputWindow)) is IVsOutputWindow outWindow)
            {
                outWindow.GetPane(ref skPaneGuid, out this.wmPane);

                if (this.wmPane == null)
                {
                    outWindow.CreatePane(ref skPaneGuid, "Show Keys", 1, 0);
                    outWindow.GetPane(ref skPaneGuid, out this.wmPane);
                }
            }
        }

        public static ShowKeysOutputPane Instance => instance ?? (instance = new ShowKeysOutputPane());

        public void Write(string message)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            this.wmPane.OutputString(message);
        }

        public void Activate()
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            this.wmPane.Activate();
        }
    }
}
