// <copyright file="AnimationHelper.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace ShowKeys
{
    public static class AnimationHelper
    {
        public static void FadeIn(DependencyObject target)
        {
            AnimateOpacity(target, double.NaN, 1, 1000);
        }

        public static void FadeOut(DependencyObject target)
        {
            AnimateOpacity(target, double.NaN, 0, 500);
        }

        private static void AnimateOpacity(DependencyObject target, double from, double to, int duration = 500)
        {
            var opacityAnimation = new DoubleAnimation
            {
                To = to,
                Duration = TimeSpan.FromMilliseconds(duration),
            };

            if (!double.IsNaN(from))
            {
                opacityAnimation.From = from;
            }

            Storyboard.SetTarget(opacityAnimation, target);
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath(nameof(UIElement.Opacity)));

            var storyboard = new Storyboard();
            storyboard.Children.Add(opacityAnimation);
            storyboard.Begin();
        }
    }
}
