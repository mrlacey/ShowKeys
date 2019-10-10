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

        [Category("Show Commands")]
        [DisplayName("Find All References")]
        [Description("Show keys when the 'Find All References' command is invoked.")]
        public bool ShowFindReferences { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Line End")]
        [Description("Show keys when the 'Line End' command is invoked.")]
        public bool ShowLineEnd { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Extend to Line End")]
        [Description("Show keys when the 'Extend to Line End' command is invoked.")]
        public bool ShowExtendToLineEnd { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Line Start")]
        [Description("Show keys when the 'Line Start' command is invoked.")]
        public bool ShowHome { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Extend to Line Start")]
        [Description("Show keys when the 'Extend to Line Start' command is invoked.")]
        public bool ShowExtendToLineStart { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Document End")]
        [Description("Show keys when the 'Go to Document End' command is invoked.")]
        public bool ShowDocumentEnd { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Document Start")]
        [Description("Show keys when the 'Go to Document Start' command is invoked.")]
        public bool ShowDocumentStart { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Collapse Tag")]
        [Description("Show keys when the 'Collapse Tag' command is invoked.")]
        public bool ShowCollapseTag { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Encapsulate Field")]
        [Description("Show keys when the 'Encapsulate Field' command is invoked.")]
        public bool ShowEncapsulateField { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Execute In Interactive")]
        [Description("Show keys when the 'Execute In Interactive' command is invoked.")]
        public bool ShowExecuteInInteractive { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Go to Brace")]
        [Description("Show keys when the 'Go to Brace' command is invoked.")]
        public bool ShowGotoBrace { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Help")]
        [Description("Show keys when the 'Help' command is invoked.")]
        public bool ShowHelp { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Insert All Matching Carets")]
        [Description("Show keys when the 'Insert All Matching Carets' command is invoked.")]
        public bool ShowInsertAllMatchingCarets { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Insert Next Matching Carets")]
        [Description("Show keys when the 'Insert Next Matching Carets' command is invoked.")]
        public bool ShowInsertNextMatchingCarets { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Navigate To Next Highlighted Reference")]
        [Description("Show keys when the 'Navigate To Next Highlighted Reference' command is invoked.")]
        public bool ShowNavigateToNextHighlightedReference { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Navigate To Previous Highlighted Reference")]
        [Description("Show keys when the 'Navigate To Previous Highlighted Reference' command is invoked.")]
        public bool ShowNavigateToPreviousHighlightedReference { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Open Line Above")]
        [Description("Show keys when the 'Open Line Above' command is invoked.")]
        public bool ShowOpenLineAbove { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Open Line Below")]
        [Description("Show keys when the 'Open Line Below' command is invoked.")]
        public bool ShowOpenLineBelow { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Outline Collapse To Definitions")]
        [Description("Show keys when the 'Outline Collapse To Definitions' command is invoked.")]
        public bool ShowOutlineCollapseToDefinitions { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Outline Hide Selection")]
        [Description("Show keys when the 'Outline Hide Selection' command is invoked.")]
        public bool ShowOutlineHideSelection { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Outline Stop Hiding Current")]
        [Description("Show keys when the 'Outline Stop Hiding Current' command is invoked.")]
        public bool ShowOutlineStopHidingCurrent { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Outline Toggle All")]
        [Description("Show keys when the 'Outline Toggle All' command is invoked.")]
        public bool ShowOutlineToggleAll { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Remove Parameters")]
        [Description("Show keys when the 'Remove Parameters' command is invoked.")]
        public bool ShowRemoveParameters { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Reorder Parameters")]
        [Description("Show keys when the 'Reorder Parameters' command is invoked.")]
        public bool ShowReorderParameters { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Show Navigate Menu")]
        [Description("Show keys when the 'Show Navigate Menu' command is invoked.")]
        public bool ShowShowNavigateMenu { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Toggle Completion Mode")]
        [Description("Show keys when the 'Toggle Completion Mode' command is invoked.")]
        public bool ShowToggleCompletionMode { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("View Call Hierarchy")]
        [Description("Show keys when the 'View Call Hierarchy' command is invoked.")]
        public bool ShowViewCallHierarchy { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Word Delete To End")]
        [Description("Show keys when the 'Word Delete To End' command is invoked.")]
        public bool ShowWordDeleteToEnd { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Word Delete To Start")]
        [Description("Show keys when the 'Word Delete To Start' command is invoked.")]
        public bool ShowWordDeleteToStart { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Navigate To Next Issue In Document")]
        [Description("Show keys when the 'Navigate To Next Issue In Document' command is invoked.")]
        public bool ShowNavigateToNextIssueInDocument { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Navigate To Previous Issue In Document")]
        [Description("Show keys when the 'Navigate To Previous Issue In Document' command is invoked.")]
        public bool ShowNavigateToPreviousIssueInDocument { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Contract Selection")]
        [Description("Show keys when the 'Contract Selection' command is invoked.")]
        public bool ShowContractSelection { get; set; } = true;

        [Category("Show Commands")]
        [DisplayName("Expand Selection")]
        [Description("Show keys when the 'Expand Selection' command is invoked.")]
        public bool ShowExpandSelection { get; set; } = true;
    }
}
