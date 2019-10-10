// <copyright file="HtmlCommandHandler.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Commanding;
using Microsoft.VisualStudio.Utilities;

namespace ShowKeys
{
    [Export(typeof(ICommandHandler))]
    [ContentType("HTML")]
    [Name(nameof(HtmlCommandHandler))]
    internal class HtmlCommandHandler : ShowKeysCommandHandler
    {
    }
}
