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
            switch (cmd)
            {
                case SupportedCommand.Cut:
                    await this.DisplayAsync(this.control, this.x).ConfigureAwait(false);
                    break;
                case SupportedCommand.Copy:
                    await this.DisplayAsync(this.control, this.c).ConfigureAwait(false);
                    break;
                case SupportedCommand.Paste:
                    await this.DisplayAsync(this.control, this.v).ConfigureAwait(false);
                    break;
                case SupportedCommand.Escape:
                    await this.DisplayAsync(this.escape).ConfigureAwait(false);
                    break;
                case SupportedCommand.Tab:
                    await this.DisplayAsync(this.tab).ConfigureAwait(false);
                    break;
                case SupportedCommand.BackTab:
                    await this.DisplayAsync(this.shift, this.tab).ConfigureAwait(false);
                    break;
                case SupportedCommand.PageDown:
                    await this.DisplayAsync(this.pageUp).ConfigureAwait(false);
                    break;
                case SupportedCommand.Delete:
                    await this.DisplayAsync(this.delete).ConfigureAwait(false);
                    break;
                case SupportedCommand.PageUp:
                    await this.DisplayAsync(this.pageUp).ConfigureAwait(false);
                    break;
                case SupportedCommand.CommentSelection:
                    await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.c).ConfigureAwait(false);
                    break;
                case SupportedCommand.UncommentSelection:
                    await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.u).ConfigureAwait(false);
                    break;
                case SupportedCommand.DuplicateSelection:
                    await this.DisplayAsync(this.control, this.d).ConfigureAwait(false);
                    break;
                case SupportedCommand.FormatDocument:
                    await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.d).ConfigureAwait(false);
                    break;
                case SupportedCommand.FormatSelection:
                    await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.f).ConfigureAwait(false);
                    break;
                case SupportedCommand.InsertSnippet:
                    await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.x).ConfigureAwait(false);
                    break;
                case SupportedCommand.InvokeQuickInfo:
                    await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.i).ConfigureAwait(false);
                    break;
                case SupportedCommand.MoveSelectedLineDown:
                    await this.DisplayAsync(this.alt, this.downArrow).ConfigureAwait(false);
                    break;
                case SupportedCommand.MoveSelectedLineUp:
                    await this.DisplayAsync(this.alt, this.upArrow).ConfigureAwait(false);
                    break;
                case SupportedCommand.Redo:
                    await this.DisplayAsync(this.control, this.y).ConfigureAwait(false);
                    break;
                case SupportedCommand.Rename:
                    await this.DisplayAsync(this.control, this.r, this.comma, this.control2, this.r2).ConfigureAwait(false);
                    break;
                case SupportedCommand.Save:
                    await this.DisplayAsync(this.control, this.s).ConfigureAwait(false);
                    break;
                case SupportedCommand.SelectAll:
                    await this.DisplayAsync(this.control, this.a).ConfigureAwait(false);
                    break;
                case SupportedCommand.SurroundWith:
                    await this.DisplayAsync(this.control, this.k, this.comma, this.control2, this.s).ConfigureAwait(false);
                    break;
                case SupportedCommand.Undo:
                    await this.DisplayAsync(this.control, this.z).ConfigureAwait(false);
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
