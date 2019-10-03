// <copyright file="DisplayedKeyPress.xaml.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShowKeys
{
    public partial class DisplayedKeyPress : UserControl
    {
        private static Guid lastRequest;

        public DisplayedKeyPress()
        {
            this.InitializeComponent();

            this.HideAllKeys();
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
                        await this.DisplayAsync(this.control, this.x).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Copy:
                    if (options.ShowCopy)
                    {
                        await this.DisplayAsync(this.control, this.c).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Paste:
                    if (options.ShowPaste)
                    {
                        await this.DisplayAsync(this.control, this.v).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Escape:
                    if (options.ShowEscape)
                    {
                        await this.DisplayAsync(this.escape).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Tab:
                    if (options.ShowTab)
                    {
                        await this.DisplayAsync(this.tab).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.BackTab:
                    if (options.ShowBackTab)
                    {
                        await this.DisplayAsync(this.shift, this.tab).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.PageDown:
                    if (options.ShowPageDown)
                    {
                        await this.DisplayAsync(this.pageUp).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Delete:
                    if (options.ShowDelete)
                    {
                        await this.DisplayAsync(this.delete).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.PageUp:
                    if (options.ShowPageUp)
                    {
                        await this.DisplayAsync(this.pageUp).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.CommentSelection:
                    if (options.ShowCommentSelection)
                    {
                        await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.c).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.UncommentSelection:
                    if (options.ShowUncommentSelection)
                    {
                        await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.u).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.DuplicateSelection:
                    if (options.ShowDuplicateSelection)
                    {
                        await this.DisplayAsync(this.control, this.d).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.FormatDocument:
                    if (options.ShowFormatDocument)
                    {
                        await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.d).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.FormatSelection:
                    if (options.ShowFormatSelection)
                    {
                        await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.f).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.InsertSnippet:
                    if (options.ShowInsertSnippet)
                    {
                        await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.x).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.InvokeQuickInfo:
                    if (options.ShowInvokeQuickInfo)
                    {
                        await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.i).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.MoveSelectedLineDown:
                    if (options.ShowMoveSelectedLineDown)
                    {
                        await this.DisplayAsync(this.alt, this.downArrow).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.MoveSelectedLineUp:
                    if (options.ShowMoveSelectedLineUp)
                    {
                        await this.DisplayAsync(this.alt, this.upArrow).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Redo:
                    if (options.ShowRedo)
                    {
                        await this.DisplayAsync(this.control, this.y).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Rename:
                    if (options.ShowRename)
                    {
                        await this.DisplayAsync(this.control, this.r, this.comma, this.control2, this.r2).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Save:
                    if (options.ShowSave)
                    {
                        await this.DisplayAsync(this.control, this.s).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.SelectAll:
                    if (options.ShowSelectAll)
                    {
                        await this.DisplayAsync(this.control, this.a).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.SurroundWith:
                    if (options.ShowSurroundWith)
                    {
                        await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.s).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.Undo:
                    if (options.ShowUndo)
                    {
                        await this.DisplayAsync(this.control, this.z).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.ViewCode:
                    if (options.ShowViewCode)
                    {
                        await this.DisplayAsync(this.f7).ConfigureAwait(false);
                    }

                    break;
                case SupportedCommand.ViewDesigner:
                    if (options.ShowViewDesigner)
                    {
                        await this.DisplayAsync(this.shift, this.f7).ConfigureAwait(false);
                    }

                    break;
                default:
                    break;
            }
        }

        private async Task DisplayAsync(params UIElement[] keys)
        {
            var requestId = Guid.NewGuid();

            lastRequest = requestId;

            this.HideAllKeys(keys);

            foreach (var key in keys)
            {
                key.Visibility = Visibility.Visible;
            }

            foreach (var key in keys)
            {
                AnimationHelper.FadeIn(key);
            }

            // Need to remain on UI Thread to do the fadeout animations
            await Task.Delay(1500).ConfigureAwait(true);

            // Don't animate out if already started showing other keys.
            if (lastRequest == requestId)
            {
                foreach (var key in keys)
                {
                    // Don't bother animating out if already made invisible
                    // because of a request to show other keys.
                    if (key.Visibility == Visibility.Visible)
                    {
                        AnimationHelper.FadeOut(key);
                    }
                }
            }
        }

        private IEnumerable<UIElement> AllElements()
        {
            yield return this.control;
            yield return this.control2;
            yield return this.comma;
            yield return this.a;
            yield return this.c;
            yield return this.d;
            yield return this.f;
            yield return this.i;
            yield return this.k;
            yield return this.r;
            yield return this.r2;
            yield return this.s;
            yield return this.u;
            yield return this.v;
            yield return this.x;
            yield return this.y;
            yield return this.z;
            yield return this.f7;
            yield return this.shift;
            yield return this.tab;
            yield return this.alt;
            yield return this.delete;
            yield return this.escape;
            yield return this.pageUp;
            yield return this.pageDown;
            yield return this.upArrow;
            yield return this.downArrow;
        }

        private void HideAllKeys(params UIElement[] apartFrom)
        {
            var apartFromList = apartFrom.ToList();

            foreach (var element in this.AllElements())
            {
                if (!apartFromList.Contains(element))
                {
                    element.Opacity = 0;
                    element.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
