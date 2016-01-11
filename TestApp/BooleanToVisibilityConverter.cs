﻿using System;
using System.Diagnostics.CodeAnalysis;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace TestApp
{
    /// <summary>
    /// Value converter that translates true to <see cref="Visibility.Visible"/> and false to <see cref="Visibility.Collapsed"/>.
    /// </summary>
    public sealed class BooleanToVisibilityConverter : IValueConverter
    {
        [SuppressMessage("Warning", "CS1591")]
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (value is bool && (bool)value) ? Visibility.Visible : Visibility.Collapsed;
        }

        [SuppressMessage("Warning", "CS1591")]
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value is Visibility && (Visibility)value == Visibility.Visible;
        }
    }
}