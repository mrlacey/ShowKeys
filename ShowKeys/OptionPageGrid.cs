// <copyright file="OptionPageGrid.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace ShowKeys
{
    public class OptionPageGrid : DialogPage
    {
        [Category("General")]
        [DisplayName("Enabled")]
        [Description("Show the keys for activated commands.")]
        public bool IsEnabled { get; set; } = true;

        [Category("General")]
        [DisplayName("Keys Foreground")]
        [Description("The color to use for the text. Can be a named value or Hex (e.g. '#FF00FF')")]
        public string Foreground { get; set; } = "Black";

        [Category("General")]
        [DisplayName("Keys Background")]
        [Description("The color to use for the key's background. Can be a named value or Hex (e.g. '#FF00FF')")]
        public string Background { get; set; } = "LightGray";

        [Category("General")]
        [DisplayName("Margin")]
        [Description("Number of pixels between the keys and the edge of the editor.")]
        public double Margin { get; set; } = 10;

        [Category("General")]
        [DisplayName("Size")]
        [Description("Size of the displayed keys.")]
        public KeySize KeySize { get; set; } = KeySize.Medium;

        [Category("Show Commands")]
        [DisplayName("Cut")]
        [Description("Show keys when the 'Cut' command is invoked.")]
        public bool ShowCut { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Copy")]
        [Description("Show keys when the 'Copy' command is invoked.")]
        public bool ShowCopy { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Paste")]
        [Description("Show keys when the 'Paste' command is invoked.")]
        public bool ShowPaste { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Escape")]
        [Description("Show keys when the 'Escape' command is invoked.")]
        public bool ShowEscape { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Tab")]
        [Description("Show keys when the 'Tab' command is invoked.")]
        public bool ShowTab { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("BackTab")]
        [Description("Show keys when the 'BackTab' command is invoked.")]
        public bool ShowBackTab { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("PageDown")]
        [Description("Show keys when the 'PageDown' command is invoked.")]
        public bool ShowPageDown { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("PageUp")]
        [Description("Show keys when the 'PageUp' command is invoked.")]
        public bool ShowPageUp { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Delete")]
        [Description("Show keys when the 'Delete' command is invoked.")]
        public bool ShowDelete { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Uncomment Selection")]
        [Description("Show keys when the 'Uncomment Selection' command is invoked.")]
        public bool ShowUncommentSelection { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Comment Selection")]
        [Description("Show keys when the 'Comment Selection' command is invoked.")]
        public bool ShowCommentSelection { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Duplicate Selection")]
        [Description("Show keys when the 'Duplicate Selection' command is invoked.")]
        public bool ShowDuplicateSelection { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Format Selection")]
        [Description("Show keys when the 'Format Selection' command is invoked.")]
        public bool ShowFormatSelection { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Format Document")]
        [Description("Show keys when the 'Format Document' command is invoked.")]
        public bool ShowFormatDocument { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Insert Snippet")]
        [Description("Show keys when the 'Insert Snippet' command is invoked.")]
        public bool ShowInsertSnippet { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Invoke Quick Info")]
        [Description("Show keys when the 'Invoke Quick Info' command is invoked.")]
        public bool ShowInvokeQuickInfo { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Move Selected Line Down")]
        [Description("Show keys when the 'Move Selected Line Down' command is invoked.")]
        public bool ShowMoveSelectedLineDown { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Move Selected Line Up")]
        [Description("Show keys when the 'Move Selected Line Up' command is invoked.")]
        public bool ShowMoveSelectedLineUp { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Redo")]
        [Description("Show keys when the 'Redo' command is invoked.")]
        public bool ShowRedo { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Undo")]
        [Description("Show keys when the 'Undo' command is invoked.")]
        public bool ShowUndo { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Rename")]
        [Description("Show keys when the 'Rename' command is invoked.")]
        public bool ShowRename { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Save")]
        [Description("Show keys when the 'Save' command is invoked.")]
        public bool ShowSave { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Select All")]
        [Description("Show keys when the 'Select All' command is invoked.")]
        public bool ShowSelectAll { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Surround With")]
        [Description("Show keys when the 'Surround With' command is invoked.")]
        public bool ShowSurroundWith { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("View Code")]
        [Description("Show keys when the 'View Code' command is invoked.")]
        public bool ShowViewCode { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("View Designer")]
        [Description("Show keys when the 'View Designer' command is invoked.")]
        public bool ShowViewDesigner { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Left")]
        [Description("Show keys when the 'Left' button is pressed.")]
        public bool ShowLeft { get; set; } = false;

        [Category("Show Commands")]
        [DisplayName("Right")]
        [Description("Show keys when the 'Right' button is pressed.")]
        public bool ShowRight { get; set; } = false;

        [Category("Show Commands")]
        [DisplayName("Return")]
        [Description("Show keys when the 'Return' (or 'Enter') button is pressed.")]
        public bool ShowReturn { get; set; } = false;

        [Category("Show Commands")]
        [DisplayName("Go To Definition")]
        [Description("Show keys when the 'Go To Definition' command is invoked.")]
        public bool ShowGoToDefinition { get; set; } = true;
    }
}
