﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TommasoScalici.AppShell
{
    public class MenuItem : DependencyObject
    {
        public static readonly DependencyProperty ArgumentsProperty =
            DependencyProperty.Register("Arguments", typeof(string), typeof(MenuItem), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty DestinationPageProperty =
            DependencyProperty.Register("DestinationPage", typeof(string), typeof(MenuItem), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty IsSelectableProperty =
            DependencyProperty.Register("IsSelectable", typeof(bool), typeof(MenuItem), new PropertyMetadata(true));
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(MenuItem), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register("Symbol", typeof(Symbol), typeof(MenuItem), new PropertyMetadata(DependencyProperty.UnsetValue));
        public static readonly DependencyProperty UIContentProperty =
            DependencyProperty.Register("UIContent", typeof(UIElement), typeof(MenuItem),
            new PropertyMetadata(DependencyProperty.UnsetValue));
        public static readonly DependencyProperty LabelVisibilityProperty =
            DependencyProperty.Register("LabelVisibility", typeof(Visibility), typeof(MenuItem),
            new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty SymbolVisibilityProperty =
            DependencyProperty.Register("SymbolVisibility", typeof(Visibility), typeof(MenuItem),
            new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty UIContentVisibilityProperty =
            DependencyProperty.Register("UIContentVisibility", typeof(Visibility), typeof(MenuItem),
            new PropertyMetadata(Visibility.Visible));


        public event EventHandler Click;


        public string Arguments
        {
            get { return (string)GetValue(ArgumentsProperty); }
            set { SetValue(ArgumentsProperty, value); }
        }
        public string DestinationPage
        {
            get { return (string)GetValue(DestinationPageProperty); }
            set { SetValue(DestinationPageProperty, value); }
        }
        public bool IsSelectable
        {
            get { return (bool)GetValue(IsSelectableProperty); }
            set { SetValue(IsSelectableProperty, value); }
        }
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        public Symbol Symbol
        {
            get { return (Symbol)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }
        public UIElement UIContent
        {
            get { return (UIElement)GetValue(UIContentProperty); }
            set { SetValue(UIContentProperty, value); }
        }
        public Visibility LabelVisibility
        {
            get { return (Visibility)GetValue(LabelVisibilityProperty); }
            set { SetValue(LabelVisibilityProperty, value); }
        }
        public Visibility SymbolVisibility
        {
            get { return (Visibility)GetValue(SymbolVisibilityProperty); }
            set { SetValue(SymbolVisibilityProperty, value); }
        }
        public Visibility UIContentVisibility
        {
            get { return (Visibility)GetValue(UIContentVisibilityProperty); }
            set { SetValue(UIContentVisibilityProperty, value); }
        }

        public char SymbolAsChar { get { return (char)Symbol; } }


        public void RaiseClick() => OnClick();

        void OnClick() => Click?.Invoke(this, EventArgs.Empty);
    }
}