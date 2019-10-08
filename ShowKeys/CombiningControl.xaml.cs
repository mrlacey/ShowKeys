// <copyright file="CombiningControl.xaml.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShowKeys
{
    public partial class CombiningControl : UserControl
    {
        public static readonly DependencyProperty CombiningTextProperty = DependencyProperty.Register("CombiningText", typeof(string), typeof(KeyControl), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty CombiningForegroundProperty = DependencyProperty.Register("CombiningForeground", typeof(Color), typeof(KeyControl), new PropertyMetadata(Colors.Black));

        public CombiningControl()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public string CombiningText
        {
            get
            {
                return (string)this.GetValue(CombiningTextProperty);
            }

            set
            {
                this.SetValue(CombiningTextProperty, value);
            }
        }

        public Color CombiningForeground
        {
            get
            {
                return (Color)this.GetValue(CombiningForegroundProperty);
            }

            set
            {
                this.SetValue(CombiningForegroundProperty, value);
            }
        }

        public SolidColorBrush CombiningForegroundBrush
        {
            get
            {
                return new SolidColorBrush(this.CombiningForeground);
            }
        }
    }
}
