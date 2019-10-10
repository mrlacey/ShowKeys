// <copyright file="KeyAlias.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.Windows.Forms;

namespace ShowKeys
{
    /// <summary>
    /// Helper class for keyboard buttons that don't map to the Keys enum.
    /// Every const must be included in the switch statement in DisplayedKeyPress.GetKeyName().
    /// </summary>
    public static class KeyAlias
    {
        public new const Keys Equals = Keys.Oemplus;

        public const Keys Minus = Keys.OemMinus;

        public const Keys ClosingSquareBrace = Keys.OemCloseBrackets;

        public const Keys SemiColon = Keys.OemSemicolon;

        public const Keys BackTick = Keys.Oem102;
    }
}
