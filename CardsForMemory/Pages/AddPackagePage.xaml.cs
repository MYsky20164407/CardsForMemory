﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace CardsForMemory.Pages {
    public sealed partial class AddPackagePage : UserControl {
        CardsForMemoryLibrary.ViewModels.AddPackagePageViewModel vm=CardsForMemory.Locator.ViewModelLocator.Instance.AddPackagePageViewModel;
        
        private Popup popup;
        public AddPackagePage() {
            RequestedTheme=App.RootTheme;
            InitializeComponent();
            popup = new Popup { Child = this };
            Width = Window.Current.Bounds.Width;
            Height = Window.Current.Bounds.Height;
            Loaded += (sender, e) => {
                Window.Current.SizeChanged += (a, b) => {
                    Width = b.Size.Width;
                    Height = b.Size.Height;
                };
            };
            Unloaded += (sender, e) => {
                Window.Current.SizeChanged -= (a, b) => {
                    Width = b.Size.Width;
                    Height = b.Size.Height;
                };
            };
            popup.IsOpen = true;
        }
    }
}
