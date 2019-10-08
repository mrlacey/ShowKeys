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

        public async Task ShowAsync(OptionPageGrid options, params Keys[] keys)
        {
            await this.ShowAsync(options, new[] { keys }).ConfigureAwait(false);
        }

        public async Task ShowAsync(OptionPageGrid options, params Keys[][] keys)
        {
            if (!options?.IsEnabled ?? false)
            {
                return;
            }

            this.Container.Margin = new Thickness(options.Margin);

            await this.DisplayAsync(options, keys).ConfigureAwait(false);
        }

        private static string GetKeyName(Keys key)
        {
            switch (key)
            {
                // PageDown and Next are treated the same
                // case Keys.PageDown:
                case Keys.Next:
                    return nameof(Keys.PageDown);

                default:
                    return key.ToString();
            }
        }

        private async Task DisplayAsync(OptionPageGrid options, params Keys[][] keys)
        {
            var requestId = Guid.NewGuid();
            lastRequest = requestId;

            this.Container.Children.Clear();
            this.Container.Opacity = 0;

            foreach (var subgroup in keys)
            {
                if (this.Container.Children.Count > 0)
                {
                    this.Container.Children.Add(new CombiningControl
                    {
                        CombiningText = ", ",
                        CombiningForeground = ColorHelper.GetColor(options.Foreground),
                    });
                }

                var firstInGroup = true;

                foreach (var key in subgroup)
                {
                    if (!firstInGroup)
                    {
                        this.Container.Children.Add(new CombiningControl
                        {
                            CombiningText = "+",
                            CombiningForeground = ColorHelper.GetColor(options.Foreground),
                        });
                    }

                    this.Container.Children.Add(new KeyControl
                    {
                        KeyText = GetKeyName(key),
                        KeyBackground = ColorHelper.GetColor(options.Background),
                        KeyForeground = ColorHelper.GetColor(options.Foreground),
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
