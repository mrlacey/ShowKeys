// <copyright file="KeySizeExtensions.cs" company="Matt Lacey Limited">
// Copyright (c) Matt Lacey Limited. All rights reserved.
// </copyright>

namespace ShowKeys
{
    public static class KeySizeExtensions
    {
        public static double SizeToScaleFactor(this KeySize source)
        {
            switch (source)
            {
                case KeySize.Small:
                    return 0.7;

                case KeySize.Large:
                    return 1.5;

                case KeySize.Medium:
                default:
                    return 1;
            }
        }
    }
}
