// <copyright file="ShowKeysCommandHandler.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.Windows.Forms;
using Microsoft.VisualStudio.Commanding;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor.Commanding.Commands;

namespace ShowKeys
{
    // Multiple content types are specified to try and capture more scenarios
    // as other handlers may suppress or intercept requests.
    // Some commands are also only handled when workign with a single content type.
    // This class is inherited by a separate type that only supports a single content type.
    // - This enables more functionality in this extension to work.
    public class ShowKeysCommandHandler :
        ICommandHandler<CutCommandArgs>,
        ICommandHandler<CopyCommandArgs>,
        ICommandHandler<PasteCommandArgs>,
        ICommandHandler<EscapeKeyCommandArgs>,
        ICommandHandler<TabKeyCommandArgs>,
        ICommandHandler<BackTabKeyCommandArgs>,
        ICommandHandler<DeleteKeyCommandArgs>,
        ICommandHandler<PageDownKeyCommandArgs>,
        ICommandHandler<PageUpKeyCommandArgs>,
        ICommandHandler<CommentSelectionCommandArgs>,
        ICommandHandler<UncommentSelectionCommandArgs>,
        ICommandHandler<DuplicateSelectionCommandArgs>,
        ICommandHandler<FormatDocumentCommandArgs>,
        ICommandHandler<FormatSelectionCommandArgs>,
        ICommandHandler<InvokeQuickInfoCommandArgs>,
        ICommandHandler<MoveSelectedLinesDownCommandArgs>,
        ICommandHandler<MoveSelectedLinesUpCommandArgs>,
        ICommandHandler<RedoCommandArgs>,
        ICommandHandler<RenameCommandArgs>,
        ICommandHandler<SaveCommandArgs>,
        ICommandHandler<SelectAllCommandArgs>,
        ICommandHandler<UndoCommandArgs>,
        ICommandHandler<ViewCodeCommandArgs>,
        ICommandHandler<ViewFormCommandArgs>,
        ICommandHandler<CollapseTagCommandArgs>,
        ICommandHandler<ContractSelectionCommandArgs>,
        ICommandHandler<DocumentEndCommandArgs>,
        ICommandHandler<DocumentStartCommandArgs>,
        ICommandHandler<EncapsulateFieldCommandArgs>,
        ICommandHandler<NavigateToNextIssueInDocumentCommandArgs>,
        ICommandHandler<NavigateToPreviousIssueInDocumentCommandArgs>,
        ICommandHandler<ExecuteInInteractiveCommandArgs>,
        ICommandHandler<ExpandSelectionCommandArgs>,
        ICommandHandler<FindReferencesCommandArgs>,
        ICommandHandler<GotoBraceCommandArgs>,
        ICommandHandler<GotoBraceExtCommandArgs>,
        ICommandHandler<GoToDefinitionCommandArgs>,
        ICommandHandler<HelpCommandArgs>,
        ICommandHandler<InsertAllMatchingCaretsCommandArgs>,
        ICommandHandler<InsertNextMatchingCaretCommandArgs>,
        ICommandHandler<LineEndCommandArgs>,
        ICommandHandler<LineEndExtendCommandArgs>,
        ICommandHandler<LineStartCommandArgs>,
        ICommandHandler<LineStartExtendCommandArgs>,
        ICommandHandler<NavigateToNextHighlightedReferenceCommandArgs>,
        ICommandHandler<NavigateToPreviousHighlightedReferenceCommandArgs>,
        ICommandHandler<OpenLineAboveCommandArgs>,
        ICommandHandler<OpenLineBelowCommandArgs>,
        ICommandHandler<OutlineCollapseToDefinitionsCommandArgs>,
        ICommandHandler<OutlineHideSelectionCommandArgs>,
        ICommandHandler<OutlineStopHidingCurrentCommandArgs>,
        ICommandHandler<OutlineToggleAllCommandArgs>,
        ICommandHandler<RemoveParametersCommandArgs>,
        ICommandHandler<ReorderParametersCommandArgs>,
        ICommandHandler<ReturnKeyCommandArgs>,
        ICommandHandler<LeftKeyCommandArgs>,
        ICommandHandler<RightKeyCommandArgs>,
        ICommandHandler<ShowNavigateMenuCommandArgs>,
        ICommandHandler<ToggleCompletionModeCommandArgs>,
        ICommandHandler<ViewCallHierarchyCommandArgs>,
        ICommandHandler<WordDeleteToEndCommandArgs>,
        ICommandHandler<WordDeleteToStartCommandArgs>
    {
        public string DisplayName => "ShowKeys";

        //// *********************************************************************************
        //// *                                   IMPORTANT!                                  *
        //// *                                   **********                                  *
        //// * All execution requests should return false as not actually handling anything. *
        //// *********************************************************************************

        public bool ExecuteCommand(CutCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowCut ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.X);
            }

            return false;
        }

        public bool ExecuteCommand(CopyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowCopy ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.C);
            }

            return false;
        }

        public bool ExecuteCommand(PasteCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowPaste ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.V);
            }

            return false;
        }

        public bool ExecuteCommand(EscapeKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowEscape ?? false)
            {
                this.ShowKeys(Keys.Escape);
            }

            return false;
        }

        public bool ExecuteCommand(TabKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowTab ?? false)
            {
                this.ShowKeys(Keys.Tab);
            }

            return false;
        }

        public bool ExecuteCommand(BackTabKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowBackTab ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.Tab);
            }

            return false;
        }

        public bool ExecuteCommand(PageDownKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowPageDown ?? false)
            {
                this.ShowKeys(Keys.PageDown);
            }

            return false;
        }

        public bool ExecuteCommand(PageUpKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowPageUp ?? false)
            {
                this.ShowKeys(Keys.PageUp);
            }

            return false;
        }

        public bool ExecuteCommand(DeleteKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowDelete ?? false)
            {
                this.ShowKeys(Keys.Delete);
            }

            return false;
        }

        public bool ExecuteCommand(CommentSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowCommentSelection ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.C });
            }

            return false;
        }

        public bool ExecuteCommand(UncommentSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowUncommentSelection ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.U });
            }

            return false;
        }

        public bool ExecuteCommand(DuplicateSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowDuplicateSelection ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.D);
            }

            return false;
        }

        public bool ExecuteCommand(FormatDocumentCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowFormatDocument ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.D });
            }

            return false;
        }

        public bool ExecuteCommand(FormatSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowFormatSelection ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.F });
            }

            return false;
        }

        public bool ExecuteCommand(InvokeQuickInfoCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowInvokeQuickInfo ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.I });
            }

            return false;
        }

        public bool ExecuteCommand(MoveSelectedLinesDownCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowMoveSelectedLineDown ?? false)
            {
                this.ShowKeys(Keys.Alt, Keys.Down);
            }

            return false;
        }

        public bool ExecuteCommand(MoveSelectedLinesUpCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowMoveSelectedLineUp ?? false)
            {
                this.ShowKeys(Keys.Alt, Keys.Up);
            }

            return false;
        }

        public bool ExecuteCommand(RedoCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowRedo ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Y);
            }

            return false;
        }

        public bool ExecuteCommand(RenameCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowRename ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.R }, new[] { Keys.Control, Keys.R });
            }

            return false;
        }

        public bool ExecuteCommand(SaveCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowSave ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.S);
            }

            return false;
        }

        public bool ExecuteCommand(SelectAllCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowSelectAll ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.A);
            }

            return false;
        }

        public bool ExecuteCommand(UndoCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowUndo ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Z);
            }

            return false;
        }

        public bool ExecuteCommand(ViewCodeCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowViewCode ?? false)
            {
                this.ShowKeys(Keys.F7);
            }

            return false;
        }

        public bool ExecuteCommand(ViewFormCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowViewDesigner ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.F7);
            }

            return false;
        }

        public bool ExecuteCommand(CollapseTagCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowCollapseTag ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.M }, new[] { Keys.Control, Keys.T });
            }

            return false;
        }

        public bool ExecuteCommand(ContractSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowContractSelection ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.Alt, KeyAlias.Minus);
            }

            return false;
        }

        public bool ExecuteCommand(DocumentEndCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowDocumentEnd ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.End);
            }

            return false;
        }

        public bool ExecuteCommand(DocumentStartCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowDocumentStart ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Home);
            }

            return false;
        }

        public bool ExecuteCommand(EncapsulateFieldCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowEncapsulateField ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.R }, new[] { Keys.Control, Keys.E });
            }

            return false;
        }

        public bool ExecuteCommand(ExecuteInInteractiveCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowExecuteInInteractive ?? false)
            {
                this.ShowKeys(Keys.Alt, Keys.Enter);
            }

            return false;
        }

        public bool ExecuteCommand(ExpandSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowExpandSelection ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.Alt, KeyAlias.Equals);
            }

            return false;
        }

        public bool ExecuteCommand(FindReferencesCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowFindReferences ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.F12);
            }

            return false;
        }

        public bool ExecuteCommand(GotoBraceCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowGotoBrace ?? false)
            {
                this.ShowKeys(Keys.Control, KeyAlias.ClosingSquareBrace);
            }

            return false;
        }

        public bool ExecuteCommand(GotoBraceExtCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowGotoBrace ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Shift, KeyAlias.ClosingSquareBrace);
            }

            return false;
        }

        public bool ExecuteCommand(GoToDefinitionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowGoToDefinition ?? false)
            {
                this.ShowKeys(Keys.F12);
            }

            return false;
        }

        public bool ExecuteCommand(HelpCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowHelp ?? false)
            {
                this.ShowKeys(Keys.F1);
            }

            return false;
        }

        public bool ExecuteCommand(InsertAllMatchingCaretsCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowInsertAllMatchingCarets ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.Alt, KeyAlias.SemiColon);
            }

            return false;
        }

        public bool ExecuteCommand(InsertNextMatchingCaretCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowInsertNextMatchingCarets ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.Alt, Keys.Decimal);
            }

            return false;
        }

        public bool ExecuteCommand(LineEndCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowLineEnd ?? false)
            {
                this.ShowKeys(Keys.End);
            }

            return false;
        }

        public bool ExecuteCommand(LineEndExtendCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowExtendToLineEnd ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.End);
            }

            return false;
        }

        public bool ExecuteCommand(LineStartCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowHome ?? false)
            {
                this.ShowKeys(Keys.Home);
            }

            return false;
        }

        public bool ExecuteCommand(LineStartExtendCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowExtendToLineStart ?? false)
            {
                this.ShowKeys(Keys.Shift, Keys.Home);
            }

            return false;
        }

        public bool ExecuteCommand(NavigateToNextHighlightedReferenceCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowNavigateToNextHighlightedReference ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Shift, Keys.Down);
            }

            return false;
        }

        public bool ExecuteCommand(NavigateToPreviousHighlightedReferenceCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowNavigateToPreviousHighlightedReference ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Shift, Keys.Up);
            }

            return false;
        }

        public bool ExecuteCommand(OpenLineAboveCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowOpenLineAbove ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Enter);
            }

            return false;
        }

        public bool ExecuteCommand(OpenLineBelowCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowOpenLineBelow ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Shift, Keys.Enter);
            }

            return false;
        }

        public bool ExecuteCommand(OutlineCollapseToDefinitionsCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowOutlineCollapseToDefinitions ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.M }, new[] { Keys.Control, Keys.O });
            }

            return false;
        }

        public bool ExecuteCommand(OutlineHideSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowOutlineHideSelection ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.M }, new[] { Keys.Control, Keys.H });
            }

            return false;
        }

        public bool ExecuteCommand(OutlineStopHidingCurrentCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowOutlineStopHidingCurrent ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.M }, new[] { Keys.Control, Keys.U });
            }

            return false;
        }

        public bool ExecuteCommand(OutlineToggleAllCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowOutlineToggleAll ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.M }, new[] { Keys.Control, Keys.L });
            }

            return false;
        }

        public bool ExecuteCommand(RemoveParametersCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowRemoveParameters ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.R }, new[] { Keys.Control, Keys.V });
            }

            return false;
        }

        public bool ExecuteCommand(ReorderParametersCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowReorderParameters ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.R }, new[] { Keys.Control, Keys.O });
            }

            return false;
        }

        public bool ExecuteCommand(ReturnKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowReturn ?? false)
            {
                this.ShowKeys(Keys.Enter);
            }

            return false;
        }

        public bool ExecuteCommand(LeftKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowLeft ?? false)
            {
                this.ShowKeys(Keys.Left);
            }

            return false;
        }

        public bool ExecuteCommand(RightKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowRight ?? false)
            {
                this.ShowKeys(Keys.Right);
            }

            return false;
        }

        public bool ExecuteCommand(ShowNavigateMenuCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowShowNavigateMenu ?? false)
            {
                this.ShowKeys(Keys.Alt, KeyAlias.BackTick);
            }

            return false;
        }

        public bool ExecuteCommand(ToggleCompletionModeCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowToggleCompletionMode ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Alt, Keys.Space);
            }

            return false;
        }

        public bool ExecuteCommand(ViewCallHierarchyCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowViewCallHierarchy ?? false)
            {
                this.ShowKeys(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.T });
            }

            return false;
        }

        public bool ExecuteCommand(WordDeleteToEndCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowWordDeleteToEnd ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Delete);
            }

            return false;
        }

        public bool ExecuteCommand(WordDeleteToStartCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowWordDeleteToStart ?? false)
            {
                this.ShowKeys(Keys.Control, Keys.Back);
            }

            return false;
        }

        public bool ExecuteCommand(NavigateToNextIssueInDocumentCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowNavigateToNextIssueInDocument ?? false)
            {
                this.ShowKeys(Keys.Alt, Keys.PageDown);
            }

            return false;
        }

        public bool ExecuteCommand(NavigateToPreviousIssueInDocumentCommandArgs args, CommandExecutionContext executionContext)
        {
            if (ShowKeysPackage.Instance?.Options.ShowNavigateToPreviousIssueInDocument ?? false)
            {
                this.ShowKeys(Keys.Alt, Keys.PageUp);
            }

            return false;
        }

        //// **********************************************************************************************
        //// *                                         IMPORTANT!                                         *
        //// *                                         **********                                         *
        //// * All handlers should return an unspecified state to not interfere with other functionality. *
        //// **********************************************************************************************

        public CommandState GetCommandState(CutCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(CopyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(PasteCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(EscapeKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(TabKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(BackTabKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(PageDownKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(PageUpKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(DeleteKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(MoveSelectedLinesDownCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(CommentSelectionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(UncommentSelectionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(DuplicateSelectionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(FormatDocumentCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(FormatSelectionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(InvokeQuickInfoCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(MoveSelectedLinesUpCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(RedoCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(RenameCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(SaveCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(SelectAllCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(UndoCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ViewCodeCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ViewFormCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(CollapseTagCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ContractSelectionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(DocumentEndCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(DocumentStartCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(EncapsulateFieldCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ExecuteInInteractiveCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ExpandSelectionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(FindReferencesCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(GotoBraceCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(GotoBraceExtCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(GoToDefinitionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(HelpCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(InsertAllMatchingCaretsCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(InsertNextMatchingCaretCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(LineEndCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(LineEndExtendCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(LineStartCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(LineStartExtendCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(NavigateToNextHighlightedReferenceCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(NavigateToPreviousHighlightedReferenceCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(OpenLineAboveCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(OpenLineBelowCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(OutlineCollapseToDefinitionsCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(OutlineHideSelectionCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(OutlineStopHidingCurrentCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(OutlineToggleAllCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(RemoveParametersCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ReorderParametersCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ReturnKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(LeftKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(RightKeyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ShowNavigateMenuCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ToggleCompletionModeCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ViewCallHierarchyCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(WordDeleteToEndCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(WordDeleteToStartCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(NavigateToNextIssueInDocumentCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(NavigateToPreviousIssueInDocumentCommandArgs args) => CommandState.Unspecified;

        private void ShowKeys(params Keys[] keys)
        {
            this.ShowKeys(new[] { keys });
        }

        private void ShowKeys(params Keys[][] keys)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(options, keys).ConfigureAwait(false);
                });
            }
        }
    }
}
