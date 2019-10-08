// <copyright file="KeyControl.xaml.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowKeys
{
    public partial class KeyControl : UserControl
    {
        public static readonly DependencyProperty KeyTextProperty = DependencyProperty.Register("KeyText", typeof(string), typeof(KeyControl), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty KeyBackgroundProperty = DependencyProperty.Register("KeyBackground", typeof(Color), typeof(KeyControl), new PropertyMetadata(Colors.LightGray, new PropertyChangedCallback(OnColorChanged)));

        public static readonly DependencyProperty KeyForegroundProperty = DependencyProperty.Register("KeyForeground", typeof(Color), typeof(KeyControl), new PropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged)));

        public KeyControl()
        {
            this.InitializeComponent();
            this.DataContext = this;

            if (DesignerProperties.GetIsInDesignMode(this))
            {
                this.KeyText = "PgUp";
            }

            ApplyGradientBorderBrush(this, this.KeyForeground, this.KeyBackground);
        }

        public string KeyText
        {
            get
            {
                return (string)this.GetValue(KeyTextProperty);
            }

            set
            {
                this.SetValue(KeyTextProperty, value);
            }
        }

        public Color KeyBackground
        {
            get
            {
                return (Color)this.GetValue(KeyBackgroundProperty);
            }

            set
            {
                this.SetValue(KeyBackgroundProperty, value);
            }
        }

        public Color KeyForeground
        {
            get
            {
                return (Color)this.GetValue(KeyForegroundProperty);
            }

            set
            {
                this.SetValue(KeyForegroundProperty, value);
            }
        }

        public SolidColorBrush KeyForegroundBrush
        {
            get
            {
                return new SolidColorBrush(this.KeyForeground);
            }
        }

        public SolidColorBrush KeyBackgroundBrush
        {
            get
            {
                return new SolidColorBrush(this.KeyBackground);
            }
        }

        private static void OnColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var kc = (KeyControl)d;

            ApplyGradientBorderBrush(kc, kc.KeyForeground, kc.KeyBackground);
        }

        private static void ApplyGradientBorderBrush(KeyControl control, Color stop1Color, Color stop2Color)
        {
            control.key.BorderBrush = new LinearGradientBrush
            {
                StartPoint = new Point(0.5, 0),
                EndPoint = new Point(0.5, 1),
                GradientStops = new GradientStopCollection(new List<GradientStop>
                {
                    new GradientStop(stop1Color, 1.5),
                    new GradientStop(stop2Color, 0.0),
                }),
            };
        }
    }
}
