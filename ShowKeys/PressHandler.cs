// <copyright file="PressHandler.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.ComponentModel.Composition;
using System.Windows.Forms;
using Microsoft.VisualStudio.Commanding;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor.Commanding.Commands;
using Microsoft.VisualStudio.Utilities;

namespace ShowKeys
{
    [Export(typeof(ICommandHandler))]
    [ContentType("text")]
    [Name("ShowKeys command listener")]
    internal class PressHandler :
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
        ICommandHandler<ExtractInterfaceCommandArgs>,
        ICommandHandler<ExtractMethodCommandArgs>,
        ICommandHandler<FindReferencesCommandArgs>,
        ICommandHandler<FormatAndValidationCommandArgs>,
        ICommandHandler<GotoBraceCommandArgs>,
        ICommandHandler<GotoBraceExtCommandArgs>,
        ICommandHandler<GoToContainingDeclarationCommandArgs>
    {
        public string DisplayName => "ShowKeys";

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

        public bool ExecuteCommand(ExtractInterfaceCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ExtractInterfaceCommandArgs");
            return false;
        }

        public bool ExecuteCommand(ExtractMethodCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** ExtractMethodCommandArgs");
            return false;
        }

        public bool ExecuteCommand(FindReferencesCommandArgs args, CommandExecutionContext executionContext)
        {
            System.Diagnostics.Debug.WriteLine("*** FindReferencesCommandArgs");
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

        public CommandState GetCommandState(ExtractInterfaceCommandArgs args)
        {
            return CommandState.Unspecified;
        }

        public CommandState GetCommandState(ExtractMethodCommandArgs args)
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
    }
}
