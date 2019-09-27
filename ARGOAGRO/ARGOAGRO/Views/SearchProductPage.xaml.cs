﻿using ARGOAGRO.ViewModels;
using Xamarin.Forms;

namespace ARGOAGRO.Views
{
    public partial class SearchProductPage : ContentPage
    {
        public SearchProductPage()
        {
            InitializeComponent();
        }

        private void CustomEntry_Unfocused(object sender, FocusEventArgs e)
        {
            (BindingContext as SearchProductPageViewModel).SubmitSearch();
        }
    }
}
