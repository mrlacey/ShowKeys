// <copyright file="XmlCommandHandler.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Commanding;
using Microsoft.VisualStudio.Utilities;

namespace ShowKeys
{
    [Export(typeof(ICommandHandler))]
    [ContentType("xml")]
    [Name(nameof(XmlCommandHandler))]
    internal class XmlCommandHandler : ShowKeysCommandHandler
    {
    }
}
