// <copyright file="KeyPressAdornment.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.Windows.Controls;
using Microsoft.VisualStudio.Text.Editor;

namespace ShowKeys
{
    internal sealed class KeyPressAdornment
    {
        private static DisplayedKeyPress root;

        private readonly IWpfTextView view;

        private readonly IAdornmentLayer adornmentLayer;

        public KeyPressAdornment(IWpfTextView view)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

            this.view = view;
            root = new DisplayedKeyPress();

            this.adornmentLayer = view.GetAdornmentLayer("KeyPressAdornment");

            this.view.ViewportHeightChanged += (sender, e) => { this.RefreshAdornment(); };
            this.view.ViewportWidthChanged += (sender, e) => { this.RefreshAdornment(); };
        }

        public static DisplayedKeyPress DisplayedInstance => root;

        private void RefreshAdornment()
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

            // Clear the adornment layer of previous adornments
            this.adornmentLayer.RemoveAllAdornments();

            Canvas.SetTop(root, this.view.ViewportBottom - root.ActualHeight);
            Canvas.SetLeft(root, (this.view.ViewportRight / 2) - 50);

            // Add to the adornment layer and make it relative to the viewport
            this.adornmentLayer.AddAdornment(AdornmentPositioningBehavior.ViewportRelative, null, null, root, null);
        }
    }
}
