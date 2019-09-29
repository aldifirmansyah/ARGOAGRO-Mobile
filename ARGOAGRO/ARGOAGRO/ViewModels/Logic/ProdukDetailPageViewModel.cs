using ARGOAGRO.ViewModels.Presentation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class ProdukDetailPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;

        private ProductViewModel _product;
        public ProductViewModel Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }

        public ImageSource BerasImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.beras.png"); }
        }

        public ProdukDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
        }

        public override void OnNavigatedTo(INavigationParameters param)
        {
            //var product = new ProductViewModel();

            if (!param.ContainsKey("productType")) return;

            Product = param.GetValue<ProductViewModel>("productType");
        }
	}
}
