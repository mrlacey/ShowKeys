// <copyright file="DisplayedKeyPress.xaml.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ShowKeys
{
    public partial class DisplayedKeyPress : System.Windows.Controls.UserControl
    {
        private static Guid lastRequest;

        public DisplayedKeyPress()
        {
            this.InitializeComponent();
        }

        public async Task ShowAsync(OptionPageGrid options, params Keys[][] keys)
        {
            if (!options?.IsEnabled ?? false)
            {
                return;
            }

            this.Container.Margin = new Thickness(options.Margin);

            await this.DisplayAsync(keys).ConfigureAwait(false);
        }

        public async Task ShowAsync(SupportedCommand cmd)
        {
            var options = ShowKeysPackage.Instance.Options;

            if (!options.IsEnabled)
            {
                return;
            }

            this.Container.Margin = new Thickness(options.Margin);

            switch (cmd)
            {
                case SupportedCommand.Cut:
                    if (options.ShowCut)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.X }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Copy:
                    if (options.ShowCopy)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.C }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Paste:
                    if (options.ShowPaste)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.V }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Escape:
                    if (options.ShowEscape)
                    {
                        await this.DisplayAsync(new[] { Keys.Escape }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Tab:
                    if (options.ShowTab)
                    {
                        await this.DisplayAsync(new[] { Keys.Tab }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.BackTab:
                    if (options.ShowBackTab)
                    {
                        await this.DisplayAsync(new[] { Keys.Shift, Keys.Tab }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.PageDown:
                    if (options.ShowPageDown)
                    {
                        await this.DisplayAsync(new[] { Keys.PageDown }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Delete:
                    if (options.ShowDelete)
                    {
                        await this.DisplayAsync(new[] { Keys.Delete }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.PageUp:
                    if (options.ShowPageUp)
                    {
                        await this.DisplayAsync(new[] { Keys.PageUp }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.CommentSelection:
                    if (options.ShowCommentSelection)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.C }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.UncommentSelection:
                    if (options.ShowUncommentSelection)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.U }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.DuplicateSelection:
                    if (options.ShowDuplicateSelection)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.D }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.FormatDocument:
                    if (options.ShowFormatDocument)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.D }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.FormatSelection:
                    if (options.ShowFormatSelection)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.F }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.InsertSnippet:
                    if (options.ShowInsertSnippet)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.X }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.InvokeQuickInfo:
                    if (options.ShowInvokeQuickInfo)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.I }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.MoveSelectedLineDown:
                    if (options.ShowMoveSelectedLineDown)
                    {
                        await this.DisplayAsync(new[] { Keys.Alt, Keys.Down }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.MoveSelectedLineUp:
                    if (options.ShowMoveSelectedLineUp)
                    {
                        await this.DisplayAsync(new[] { Keys.Alt, Keys.Up }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Redo:
                    if (options.ShowRedo)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.Y }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Rename:
                    if (options.ShowRename)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.R }, new[] { Keys.Control, Keys.R }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Save:
                    if (options.ShowSave)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.S }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.SelectAll:
                    if (options.ShowSelectAll)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.A }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.SurroundWith:
                    if (options.ShowSurroundWith)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.K }, new[] { Keys.Control, Keys.S }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Undo:
                    if (options.ShowUndo)
                    {
                        await this.DisplayAsync(new[] { Keys.Control, Keys.Z }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.ViewCode:
                    if (options.ShowViewCode)
                    {
                        await this.DisplayAsync(new[] { Keys.F7 }).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.ViewDesigner:
                    if (options.ShowViewDesigner)
                    {
                        await this.DisplayAsync(new[] { Keys.Shift, Keys.F7 }).ConfigureAwait(false);
                    }

                    break;
                default:
                    break;
            }
        }

        private async Task DisplayAsync(params Keys[][] keys)
        {
            var requestId = Guid.NewGuid();
            lastRequest = requestId;

            this.Container.Children.Clear();
            this.Container.Opacity = 0;

            foreach (var subgroup in keys)
            {
                if (this.Container.Children.Count > 0)
                {
                    this.Container.Children.Add(new CombiningControl { CombiningText = ", " });
                }

                var firstInGroup = true;

                foreach (var key in subgroup)
                {
                    if (!firstInGroup)
                    {
                        this.Container.Children.Add(new CombiningControl { CombiningText = "+" });
                    }

                    this.Container.Children.Add(new KeyControl
                    {
                        KeyText = key.ToString(),
                    });

                    firstInGroup = false;
                }
            }

            AnimationHelper.FadeIn(this.Container);

            // Need to remain on UI Thread to do the fadeout animations
            await Task.Delay(1500).ConfigureAwait(true);

            // Don't animate out if already started showing other keys.
            if (lastRequest == requestId)
            {
                AnimationHelper.FadeOut(this.Container);
            }
        }
    }
}
