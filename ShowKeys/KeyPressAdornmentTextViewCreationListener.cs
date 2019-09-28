// <copyright file="KeyPressAdornmentTextViewCreationListener.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace ShowKeys
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType("text")]
    [TextViewRole(PredefinedTextViewRoles.Document)]
    internal sealed class KeyPressAdornmentTextViewCreationListener : IWpfTextViewCreationListener
    {
        // Disable "Field is never assigned to..." and "Field is never used" compiler's warnings. Justification: the field is used by MEF.
#pragma warning disable 649, 169
#pragma warning disable IDE0051 // Remove unused private members
#pragma warning disable IDE0044 // Add readonly modifier
        [Export(typeof(AdornmentLayerDefinition))]
        [Name("KeyPressAdornment")]
        [Order(After = PredefinedAdornmentLayers.Caret)]
        private AdornmentLayerDefinition editorAdornmentLayer;
#pragma warning restore IDE0044 // Add readonly modifier
#pragma warning restore IDE0051 // Remove unused private members
#pragma warning restore 649, 169

        public void TextViewCreated(IWpfTextView textView)
        {
            _ = new KeyPressAdornment(textView);
        }
    }
}
