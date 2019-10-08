// <copyright file="KeyPressAdornment.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.Windows.Controls;
using Microsoft.VisualStudio.Text.Editor;

namespace ShowKeys
{
    internal sealed class KeyPressAdornment
    {
        private readonly IWpfTextView view;

        private readonly IAdornmentLayer adornmentLayer;

        public KeyPressAdornment(IWpfTextView view)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

            this.view = view;
            DisplayedInstance = new DisplayedKeyPress();

            this.adornmentLayer = view.GetAdornmentLayer("KeyPressAdornment");

            this.view.ViewportHeightChanged += (sender, e) => { this.RefreshAdornment(); };
            this.view.ViewportWidthChanged += (sender, e) => { this.RefreshAdornment(); };
        }

        public static DisplayedKeyPress DisplayedInstance { get; private set; }

        private void RefreshAdornment()
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

            // Clear the adornment layer of previous adornments
            this.adornmentLayer.RemoveAllAdornments();

            var margin = ShowKeysPackage.Instance?.Options?.Margin ?? 10;

            var controlHeight = DisplayedInstance.ActualHeight;

            if (controlHeight < 10 || double.IsNaN(controlHeight))
            {
                controlHeight = 60;  // Default control height
            }

            Canvas.SetTop(DisplayedInstance, this.view.ViewportBottom - controlHeight - (margin * 2)); // Double the margin for top and botom

            // Put it on the left, allow alignment to center
            Canvas.SetLeft(DisplayedInstance, 0);
            DisplayedInstance.Width = this.view.ViewportWidth;

            // Add to the adornment layer and make it relative to the viewport
            this.adornmentLayer.AddAdornment(AdornmentPositioningBehavior.ViewportRelative, null, null, DisplayedInstance, null);
        }
    }
}
