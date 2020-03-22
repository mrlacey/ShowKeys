// <copyright file="KeyPressAdornment.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
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
            try
            {
                Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

                // Clear the adornment layer of previous adornments
                this.adornmentLayer.RemoveAllAdornments();

                var margin = ShowKeysPackage.Instance?.Options?.Margin ?? 10;

                var controlHeight = 150; // Default margin container height

                Canvas.SetTop(DisplayedInstance, this.view.ViewportBottom - controlHeight - 10); // Move another 10 pixesl to allow for the scrollbars being counted as part of the viewport

                // Put it on the left, allow content alignment to center
                Canvas.SetLeft(DisplayedInstance, 0);
                DisplayedInstance.Width = this.view.ViewportWidth;

                // Add to the adornment layer and make it relative to the viewport
                this.adornmentLayer.AddAdornment(AdornmentPositioningBehavior.ViewportRelative, null, null, DisplayedInstance, null);
            }
            catch (InvalidOperationException ioe)
            {
                // This can occur when resizing or loading windows while the adornment is loading.
                System.Diagnostics.Debug.WriteLine(ioe);
                ShowKeysOutputPane.Instance.WriteError(ioe);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception exc)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                System.Diagnostics.Debug.WriteLine(exc);
                ShowKeysOutputPane.Instance.WriteError(ex);
            }
        }
    }
}
