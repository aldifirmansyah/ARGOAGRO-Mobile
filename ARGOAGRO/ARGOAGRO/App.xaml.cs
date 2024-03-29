﻿using Prism;
using Prism.Ioc;
using ARGOAGRO.ViewModels;
using ARGOAGRO.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ARGOAGRO
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchProductPage, SearchProductPageViewModel>();
            containerRegistry.RegisterForNavigation<ProdukPage, ProdukPageViewModel>();
            containerRegistry.RegisterForNavigation<ProdukDetailPage, ProdukDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ProdukDetail2Page, ProdukDetail2PageViewModel>();
            containerRegistry.RegisterForNavigation<PreorderPage, PreorderPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductReviewPage, ProductReviewPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisPage, RegisPageViewModel>();
            containerRegistry.RegisterForNavigation<QuestionPage, QuestionPageViewModel>();
            containerRegistry.RegisterForNavigation<ContactPage, ContactPageViewModel>();
        }
    }
}
