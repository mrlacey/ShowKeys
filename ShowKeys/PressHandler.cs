// <copyright file="PressHandler.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.ComponentModel.Composition;
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
        ICommandHandler<ViewFormCommandArgs>
    {
        public string DisplayName => "ShowKeys";

        public bool ExecuteCommand(CutCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Cut).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(CopyCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Copy).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(PasteCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Paste).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(EscapeKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Escape).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(TabKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Tab).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(BackTabKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.PageDown).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(PageDownKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.PageDown).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(PageUpKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.PageUp).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(DeleteKeyCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Delete).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(CommentSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.CommentSelection).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(UncommentSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.UncommentSelection).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(DuplicateSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.DuplicateSelection).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(FormatDocumentCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.FormatDocument).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(FormatSelectionCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.FormatSelection).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(InsertSnippetCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.InsertSnippet).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(InvokeQuickInfoCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.InvokeQuickInfo).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(MoveSelectedLinesDownCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.MoveSelectedLineDown).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(MoveSelectedLinesUpCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.MoveSelectedLineUp).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(RedoCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Redo).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(RenameCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Rename).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(SaveCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Save).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(SelectAllCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.SelectAll).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(SurroundWithCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.SurroundWith).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(UndoCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.Undo).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(ViewCodeCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.ViewCode).ConfigureAwait(false);
            });
            return false;
        }

        public bool ExecuteCommand(ViewFormCommandArgs args, CommandExecutionContext executionContext)
        {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () =>
            {
                await KeyPressAdornment.DisplayedInstance.ShowAsync(SupportedCommand.ViewDesigner).ConfigureAwait(false);
            });
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
    }
}
