﻿// <copyright file="ShowKeysCommandHandler.cs" company="Matt Lacey Limited">
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
        ICommandHandler<InsertSnippetCommandArgs>,
        ICommandHandler<InvokeQuickInfoCommandArgs>,
        ICommandHandler<MoveSelectedLinesDownCommandArgs>,
        ICommandHandler<MoveSelectedLinesUpCommandArgs>,
        ICommandHandler<RedoCommandArgs>,
        ICommandHandler<RenameCommandArgs>,
        ICommandHandler<SaveCommandArgs>,
        ICommandHandler<SelectAllCommandArgs>,
        ICommandHandler<SurroundWithCommandArgs>,
        ICommandHandler<UndoCommandArgs>,
        ICommandHandler<ViewCodeCommandArgs>,
        ICommandHandler<ViewFormCommandArgs>,
        ICommandHandler<AutomaticLineEnderCommandArgs>,
        ICommandHandler<CodeCleanUpCommandArgs>,
        ICommandHandler<CollapseTagCommandArgs>,
        ICommandHandler<CommitUniqueCompletionListItemCommandArgs>,
        ICommandHandler<ContractSelectionCommandArgs>,
        ICommandHandler<CopyToInteractiveCommandArgs>,
        ICommandHandler<DocumentEndCommandArgs>,
        ICommandHandler<DocumentStartCommandArgs>,
        ICommandHandler<EncapsulateFieldCommandArgs>,
        ICommandHandler<ErrorCommandArgsBase>,
        ICommandHandler<ExecuteInInteractiveCommandArgs>,
        ICommandHandler<ExpandSelectionCommandArgs>,
        ICommandHandler<FindReferencesCommandArgs>,
        ICommandHandler<FormatAndValidationCommandArgs>,
        ICommandHandler<GotoBraceCommandArgs>,
        ICommandHandler<GotoBraceExtCommandArgs>,
        ICommandHandler<GoToContainingDeclarationCommandArgs>,
        ICommandHandler<GoToDefinitionCommandArgs>,
        ICommandHandler<GoToNextMemberCommandArgs>,
        ICommandHandler<GoToPreviousMemberCommandArgs>,
        ICommandHandler<HelpCommandArgs>,
        ICommandHandler<InsertAllMatchingCaretsCommandArgs>,
        ICommandHandler<InsertCommentCommandArgs>,
        ICommandHandler<InsertNextMatchingCaretCommandArgs>,
        ICommandHandler<InvokeCompletionListCommandArgs>,
        ICommandHandler<InvokeSignatureHelpCommandArgs>,
        ICommandHandler<LineEndCommandArgs>,
        ICommandHandler<LineEndExtendCommandArgs>,
        ICommandHandler<LineStartCommandArgs>,
        ICommandHandler<LineStartExtendCommandArgs>,
        ICommandHandler<MoveLastCaretDownCommandArgs>,
        ICommandHandler<NavigateToNextHighlightedReferenceCommandArgs>,
        ICommandHandler<NavigateToPreviousHighlightedReferenceCommandArgs>,
        ICommandHandler<OpenLineAboveCommandArgs>,
        ICommandHandler<OpenLineBelowCommandArgs>,
        ICommandHandler<OutlineCollapseToDefinitionsCommandArgs>,
        ICommandHandler<OutlineHideSelectionCommandArgs>,
        ICommandHandler<OutlineStopHidingAllCommandArgs>,
        ICommandHandler<OutlineStopHidingCurrentCommandArgs>,
        ICommandHandler<OutlineToggleAllCommandArgs>,
        ICommandHandler<OutlineToggleCurrentCommandArgs>,
        ICommandHandler<PasteAsHTMLCommandArgs>,
        ICommandHandler<RemoveLastSecondaryCaretCommandArgs>,
        ICommandHandler<RemoveParametersCommandArgs>,
        ICommandHandler<ReorderParametersCommandArgs>,
        ICommandHandler<ReturnKeyCommandArgs>,
        ICommandHandler<LeftKeyCommandArgs>,
        ICommandHandler<RightKeyCommandArgs>,
        ICommandHandler<RotatePrimaryCaretNextCommandArgs>,
        ICommandHandler<RotatePrimaryCaretPreviousCommandArgs>,
        ICommandHandler<SelectContainingDeclarationCommandArgs>,
        ICommandHandler<ShowClipboardHistoryCommandArgs>,
        ICommandHandler<ShowNavigateMenuCommandArgs>,
        ICommandHandler<StartAutomaticOutliningCommandArgs>,
        ICommandHandler<SyncClassViewCommandArgs>,
        ICommandHandler<ToggleCompletionModeCommandArgs>,
        ICommandHandler<UncollapseTagCommandArgs>,
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

        public bool ExecuteCommand(InsertSnippetCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowInsertSnippet)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.K },
                        new[] { Keys.Control, Keys.X }).ConfigureAwait(false);
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

        public bool ExecuteCommand(SurroundWithCommandArgs args, CommandExecutionContext executionContext)
        {
            var options = ShowKeysPackage.Instance?.Options;

            if (options?.IsEnabled ?? false && options.ShowSurroundWith)
            {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
                {
                    await KeyPressAdornment.DisplayedInstance.ShowAsync(
                        options,
                        new[] { Keys.Control, Keys.K },
                        new[] { Keys.Control, Keys.S }).ConfigureAwait(false);
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

        public bool ExecuteCommand(AutomaticLineEnderCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** AutomaticLineEnderCommandArgs");
            return false;
        }

        public bool ExecuteCommand(CodeCleanUpCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** CodeCleanUpCommandArgs");
            return false;
        }

        public bool ExecuteCommand(CollapseTagCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** CollapseTagCommandArgs");
            return false;
        }

        public bool ExecuteCommand(CommitUniqueCompletionListItemCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** CommitUniqueCompletionListItemCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ContractSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ContractSelectionCommandArgs");
            return false;
        }

        public bool ExecuteCommand(CopyToInteractiveCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** CopyToInteractiveCommandArgs");
            return false;
        }

        public bool ExecuteCommand(DocumentEndCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** DocumentEndCommandArgs");
            return false;
        }

        public bool ExecuteCommand(DocumentStartCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** DocumentStartCommandArgs");
            return false;
        }

        public bool ExecuteCommand(EncapsulateFieldCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** EncapsulateFieldCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ErrorCommandArgsBase args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ErrorCommandArgsBase");
            return false;
        }

        public bool ExecuteCommand(ExecuteInInteractiveCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ExecuteInInteractiveCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ExpandSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ExpandSelectionCommandArgs");
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

        public bool ExecuteCommand(FormatAndValidationCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** FormatAndValidationCommandArgs");
            return false;
        }

        public bool ExecuteCommand(GotoBraceCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** GotoBraceCommandArgs");
            return false;
        }

        public bool ExecuteCommand(GotoBraceExtCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** GotoBraceExtCommandArgs");
            return false;
        }

        public bool ExecuteCommand(GoToContainingDeclarationCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** GoToContainingDeclarationCommandArgs");
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

        public bool ExecuteCommand(GoToNextMemberCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** GoToNextMemberCommandArgs");
            return false;
        }

        public bool ExecuteCommand(GoToPreviousMemberCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** GoToPreviousMemberCommandArgs");
            return false;
        }

        public bool ExecuteCommand(HelpCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** HelpCommandArgs");
            return false;
        }

        public bool ExecuteCommand(InsertAllMatchingCaretsCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** InsertAllMatchingCaretsCommandArgs");
            return false;
        }

        public bool ExecuteCommand(InsertCommentCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** InsertCommentCommandArgs");
            return false;
        }

        public bool ExecuteCommand(InsertNextMatchingCaretCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** InsertNextMatchingCaretCommandArgs");
            return false;
        }

        public bool ExecuteCommand(InvokeCompletionListCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** InvokeCompletionListCommandArgs");
            return false;
        }

        public bool ExecuteCommand(InvokeSignatureHelpCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** InvokeSignatureHelpCommandArgs");
            return false;
        }

        public bool ExecuteCommand(LineEndCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** LineEndCommandArgs");
            return false;
        }

        public bool ExecuteCommand(LineEndExtendCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** LineEndExtendCommandArgs");
            return false;
        }

        public bool ExecuteCommand(LineStartCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** LineStartCommandArgs");
            return false;
        }

        public bool ExecuteCommand(LineStartExtendCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** LineStartExtendCommandArgs");
            return false;
        }

        public bool ExecuteCommand(MoveLastCaretDownCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** MoveLastCaretDownCommandArgs");
            return false;
        }

        public bool ExecuteCommand(NavigateToNextHighlightedReferenceCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** NavigateToNextHighlightedReferenceCommandArgs");
            return false;
        }

        public bool ExecuteCommand(NavigateToPreviousHighlightedReferenceCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** NavigateToPreviousHighlightedReferenceCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OpenLineAboveCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OpenLineAboveCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OpenLineBelowCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OpenLineBelowCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OutlineCollapseToDefinitionsCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineCollapseToDefinitionsCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OutlineHideSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineHideSelectionCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OutlineStopHidingAllCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineStopHidingAllCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OutlineStopHidingCurrentCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineStopHidingCurrentCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OutlineToggleAllCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineToggleAllCommandArgs");
            return false;
        }

        public bool ExecuteCommand(OutlineToggleCurrentCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** OutlineToggleCurrentCommandArgs");
            return false;
        }

        public bool ExecuteCommand(PasteAsHTMLCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** PasteAsHTMLCommandArgs");
            return false;
        }

        public bool ExecuteCommand(RemoveLastSecondaryCaretCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** RemoveLastSecondaryCaretCommandArgs");
            return false;
        }

        public bool ExecuteCommand(RemoveParametersCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** RemoveParametersCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ReorderParametersCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ReorderParametersCommandArgs");
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

        public bool ExecuteCommand(RotatePrimaryCaretNextCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** RotatePrimaryCaretNextCommandArgs");
            return false;
        }

        public bool ExecuteCommand(RotatePrimaryCaretPreviousCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** RotatePrimaryCaretPreviousCommandArgs");
            return false;
        }

        public bool ExecuteCommand(SelectContainingDeclarationCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** SelectContainingDeclarationCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ShowClipboardHistoryCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ShowClipboardHistoryCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ShowNavigateMenuCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ShowNavigateMenuCommandArgs");
            return false;
        }

        public bool ExecuteCommand(StartAutomaticOutliningCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** StartAutomaticOutliningCommandArgs");
            return false;
        }

        public bool ExecuteCommand(SyncClassViewCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** SyncClassViewCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ToggleCompletionModeCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ToggleCompletionModeCommandArgs");
            return false;
        }

        public bool ExecuteCommand(UncollapseTagCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** UncollapseTagCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ViewCallHierarchyCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ViewCallHierarchyCommandArgs");
            return false;
        }

        public bool ExecuteCommand(WordDeleteToEndCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** WordDeleteToEndCommandArgs");
            return false;
        }

        public bool ExecuteCommand(WordDeleteToStartCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** WordDeleteToStartCommandArgs");
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

        public CommandState GetCommandState(InsertSnippetCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(InvokeQuickInfoCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(MoveSelectedLinesUpCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(RedoCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(RenameCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(SaveCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(SelectAllCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(SurroundWithCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(UndoCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ViewCodeCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(ViewFormCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(AutomaticLineEnderCommandArgs args) => CommandState.Unspecified;

        public CommandState GetCommandState(CodeCleanUpCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(CollapseTagCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(CommitUniqueCompletionListItemCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ContractSelectionCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(CopyToInteractiveCommandArgs args)
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

        public CommandState GetCommandState(ErrorCommandArgsBase args)
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

        public CommandState GetCommandState(FormatAndValidationCommandArgs args)
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

        public CommandState GetCommandState(GoToContainingDeclarationCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(GoToDefinitionCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(GoToNextMemberCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(GoToPreviousMemberCommandArgs args)
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

        public CommandState GetCommandState(InsertCommentCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(InsertNextMatchingCaretCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(InvokeCompletionListCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(InvokeSignatureHelpCommandArgs args)
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

        public CommandState GetCommandState(MoveLastCaretDownCommandArgs args)
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

        public CommandState GetCommandState(OutlineStopHidingAllCommandArgs args)
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

        public CommandState GetCommandState(OutlineToggleCurrentCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(PasteAsHTMLCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(RemoveLastSecondaryCaretCommandArgs args)
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

        public CommandState GetCommandState(RotatePrimaryCaretNextCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(RotatePrimaryCaretPreviousCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(SelectContainingDeclarationCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ShowClipboardHistoryCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ShowNavigateMenuCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(StartAutomaticOutliningCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(SyncClassViewCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ToggleCompletionModeCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(UncollapseTagCommandArgs args)
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
    }
}
