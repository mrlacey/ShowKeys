// <copyright file="DisplayedKeyPress.xaml.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ShowKeys
{
    public partial class DisplayedKeyPress : System.Windows.Controls.UserControl
    {
        private static Guid lastRequest;
        private string currentlyShowing;

        public DisplayedKeyPress()
        {
            this.InitializeComponent();
        }

        public static string KeysAsString(Keys[][] keys)
        {
            var result = new StringBuilder();

            if (keys != null)
            {
                foreach (var group in keys)
                {
                    foreach (var key in group)
                    {
                        result.Append(key.ToString());
                    }
                }
            }

            return result.ToString();
        }

        public async Task ShowAsync(OptionPageGrid options, params Keys[] keys)
        {
            await this.ShowAsync(options, new[] { keys }).ConfigureAwait(false);
        }

        public async Task ShowAsync(OptionPageGrid options, string shortcut)
        {
            if (!options?.IsEnabled ?? false)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(shortcut))
            {
                return;
            }

            if (this.currentlyShowing == shortcut)
            {
                return;
            }

            this.currentlyShowing = shortcut;

            try
            {
                this.Wrapper.Margin = new Thickness(options.Margin);

                await this.DisplayAsync(options, shortcut).ConfigureAwait(false);
            }
            finally
            {
                this.currentlyShowing = null;
            }
        }

        public async Task ShowAsync(OptionPageGrid options, params Keys[][] keys)
        {
            if (!options?.IsEnabled ?? false)
            {
                return;
            }

            // Avoid showing the same keys in quick succession if triggered by multiple content types
            var keysString = KeysAsString(keys);

            if (this.currentlyShowing == keysString)
            {
                return;
            }

            this.currentlyShowing = keysString;

            try
            {
                this.Wrapper.Margin = new Thickness(options.Margin);

                await this.DisplayAsync(options, keys).ConfigureAwait(false);
            }
            finally
            {
                this.currentlyShowing = null;
            }
        }

        private static string GetKeyName(Keys key)
        {
            switch (key)
            {
                // PageDown and Next are treated the same
                // case Keys.PageDown:
                case Keys.Next:
                    return nameof(Keys.PageDown);
                case KeyAlias.Equals:
                    return "=";
                case KeyAlias.Minus:
                    return "-";
                case KeyAlias.ClosingSquareBrace:
                    return "]";
                case KeyAlias.SemiColon:
                    return ";";
                case KeyAlias.BackTick:
                    return "`";

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

            this.Wrapper.Height = 60 * options.KeySize.SizeToScaleFactor();

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

        private async Task DisplayAsync(OptionPageGrid options, string shortcut)
        {
            var requestId = Guid.NewGuid();
            lastRequest = requestId;

            this.Container.Children.Clear();
            this.Container.Opacity = 0;

            this.Wrapper.Height = 60 * options.KeySize.SizeToScaleFactor();

            foreach (var subgroup in shortcut.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
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

                foreach (var key in subgroup.Split(new[] { "+" }, StringSplitOptions.RemoveEmptyEntries))
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
                        KeyText = key.Trim(),
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
