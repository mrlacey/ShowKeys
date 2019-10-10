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
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowCut)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.X).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(CopyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowCut)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.C).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(PasteCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowPaste)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.V }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(EscapeKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowEscape)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Escape }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(TabKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowTab)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Tab }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(BackTabKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowBackTab)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Shift,
                        Keys.Tab).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(PageDownKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowPageDown)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.PageDown).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(PageUpKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowPageUp)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.PageUp).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(DeleteKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowPageUp)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Delete).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(CommentSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowCommentSelection)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.K },
                        new[] { Keys.Control, Keys.C }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(UncommentSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowUncommentSelection)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.K },
                        new[] { Keys.Control, Keys.U }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(DuplicateSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowDuplicateSelection)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.D).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(FormatDocumentCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowFormatDocument)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.K },
                        new[] { Keys.Control, Keys.D }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(FormatSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowFormatSelection)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.K },
                        new[] { Keys.Control, Keys.F }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(InvokeQuickInfoCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowInvokeQuickInfo)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.K },
                        new[] { Keys.Control, Keys.I }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(MoveSelectedLinesDownCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowMoveSelectedLineDown)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Alt,
                        Keys.Down).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(MoveSelectedLinesUpCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowMoveSelectedLineUp)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Alt,
                        Keys.Up).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(RedoCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowRedo)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.Y).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(RenameCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowRename)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.R },
                        new[] { Keys.Control, Keys.R }).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(SaveCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowSave)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.S).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(SelectAllCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowSelectAll)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.A).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(UndoCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowUndo)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.Z).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(ViewCodeCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowViewCode)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.F7).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(ViewFormCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowViewDesigner)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Shift,
                        Keys.F7).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(CollapseTagCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** CollapseTagCommandArgs 'Ctrl+M, Ctrl+T'");
            return false;
        }

        public bool ExecuteCommand(ContractSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ContractSelectionCommandArgs 'Shift+Alt+-'");
            return false;
        }

        public bool ExecuteCommand(DocumentEndCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowDocumentEnd)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.End).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(DocumentStartCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowDocumentStart)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Control,
                        Keys.Home).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(EncapsulateFieldCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** EncapsulateFieldCommandArgs 'Ctrl+R, Ctrl+E'");
            return false;
        }

        public bool ExecuteCommand(ExecuteInInteractiveCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ExecuteInInteractiveCommandArgs 'Alt+Enter'");
            return false;
        }

        public bool ExecuteCommand(ExpandSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ExpandSelectionCommandArgs 'Shift+Alt+='");
            return false;
        }

        public bool ExecuteCommand(FindReferencesCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowFindReferences)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Shift,
                        Keys.F12).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(GotoBraceCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** GotoBraceCommandArgs 'Ctrl+]'");
            return false;
        }

        public bool ExecuteCommand(GotoBraceExtCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** GotoBraceExtCommandArgs 'Ctrl+Shift+]'");
            return false;
        }

        public bool ExecuteCommand(GoToDefinitionCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowGoToDefinition)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.F12).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(HelpCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** HelpCommandArgs 'F1'");
            return false;
        }

        public bool ExecuteCommand(InsertAllMatchingCaretsCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** InsertAllMatchingCaretsCommandArgs 'Shift+Alt+;'");
            return false;
        }

        public bool ExecuteCommand(InsertNextMatchingCaretCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** InsertNextMatchingCaretCommandArgs 'Shift+Alt+.'");
            return false;
        }

        public bool ExecuteCommand(LineEndCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowLineEnd)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.End).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(LineEndExtendCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowExtendToLineEnd)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Shift,
                        Keys.End).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(LineStartCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowHome)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Home).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(LineStartExtendCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowExtendToLineStart)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Shift,
                        Keys.Home).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(NavigateToNextHighlightedReferenceCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** NavigateToNextHighlightedReferenceCommandArgs '	Ctrl+Shift+Down Arrow'");
            return false;
        }

        public bool ExecuteCommand(NavigateToPreviousHighlightedReferenceCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** NavigateToPreviousHighlightedReferenceCommandArgs 'Ctrl+Shift+Up Arrow'");
            return false;
        }

        public bool ExecuteCommand(OpenLineAboveCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OpenLineAboveCommandArgs 'Ctrl+Enter'");
            return false;
        }

        public bool ExecuteCommand(OpenLineBelowCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OpenLineBelowCommandArgs 'Ctrl+Shift+Enter'");
            return false;
        }

        public bool ExecuteCommand(OutlineCollapseToDefinitionsCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineCollapseToDefinitionsCommandArgs 'Ctrl+M, Ctrl+O '");
            return false;
        }

        public bool ExecuteCommand(OutlineHideSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineHideSelectionCommandArgs 'Ctrl+M, Ctrl+H'");
            return false;
        }

        public bool ExecuteCommand(OutlineStopHidingCurrentCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineStopHidingCurrentCommandArgs 'Ctrl+M, Ctrl+U'");
            return false;
        }

        public bool ExecuteCommand(OutlineToggleAllCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineToggleAllCommandArgs 'Ctrl+M, Ctrl+L'");
            return false;
        }

        public bool ExecuteCommand(RemoveParametersCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** RemoveParametersCommandArgs 'Ctrl+R, Ctrl+V'");
            return false;
        }

        public bool ExecuteCommand(ReorderParametersCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ReorderParametersCommandArgs 'Ctrl+R, Ctrl+O'");
            return false;
        }

        public bool ExecuteCommand(ReturnKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowReturn)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Enter).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(LeftKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowLeft)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Left).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(RightKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowRight)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        Keys.Right).ConfigureAwait(false);
                });
            }

            return false;
        }

        public bool ExecuteCommand(ShowNavigateMenuCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ShowNavigateMenuCommandArgs 'Alt+`'");
            return false;
        }

        public bool ExecuteCommand(ToggleCompletionModeCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ToggleCompletionModeCommandArgs 'Ctrl+Alt+Space'");
            return false;
        }

        public bool ExecuteCommand(ViewCallHierarchyCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ViewCallHierarchyCommandArgs 'Ctrl+K, Ctrl+T'");
            return false;
        }

        public bool ExecuteCommand(WordDeleteToEndCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** WordDeleteToEndCommandArgs 'Ctrl+Delete'");
            return false;
        }

        public bool ExecuteCommand(WordDeleteToStartCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** WordDeleteToStartCommandArgs '	Ctrl+Backspace'");
            return false;
        }

        public bool ExecuteCommand(NavigateToNextIssueInDocumentCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** NavigateToNextIssueInDocumentCommandArgs 'Alt+PgDn'");
            return false;
        }

        public bool ExecuteCommand(NavigateToPreviousIssueInDocumentCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** NavigateToPreviousIssueInDocumentCommandArgs 'Alt+PgUp'");
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

        public CommandState GetCommandState(CollapseTagCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ContractSelectionCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(DocumentEndCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(DocumentStartCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(EncapsulateFieldCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ExecuteInInteractiveCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ExpandSelectionCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(FindReferencesCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(GotoBraceCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(GotoBraceExtCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(GoToDefinitionCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(HelpCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(InsertAllMatchingCaretsCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(InsertNextMatchingCaretCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(LineEndCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(LineEndExtendCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(LineStartCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(LineStartExtendCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(NavigateToNextHighlightedReferenceCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(NavigateToPreviousHighlightedReferenceCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(OpenLineAboveCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(OpenLineBelowCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(OutlineCollapseToDefinitionsCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(OutlineHideSelectionCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(OutlineStopHidingCurrentCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(OutlineToggleAllCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(RemoveParametersCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ReorderParametersCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ReturnKeyCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(LeftKeyCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(RightKeyCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ShowNavigateMenuCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ToggleCompletionModeCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ViewCallHierarchyCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(WordDeleteToEndCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(WordDeleteToStartCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(NavigateToNextIssueInDocumentCommandArgs args)
        {
            throw new System.NotImplementedException();
        }

        public CommandState GetCommandState(NavigateToPreviousIssueInDocumentCommandArgs args)
        {
            throw new System.NotImplementedException();
        }
    }
}
