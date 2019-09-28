using ARGOAGRO.Services;
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
	public class ProdukPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private ProductService _productService = new ProductService();

        public IEnumerable<ProductViewModel> AllProducts;

        public DelegateCommand<String> ProductDetailCommand => new DelegateCommand<String>((productType) =>
        {
            var param = new NavigationParameters();
            var key = "productType";

            if (productType == "beras") param.Add(key, AllProducts.ElementAt(0));
            else if (productType == "durian") param.Add(key, AllProducts.ElementAt(1));
            else if (productType == "kakao") param.Add(key, AllProducts.ElementAt(2));
            else param.Add(key, AllProducts.ElementAt(3));

            _navigationService.NavigateAsync("ProdukDetailPage", param);
        });
        

        public ProdukPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;

            AllProducts = _productService.GetAllProduct();
        }



        public ImageSource PadiImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.padi.png"); }
        }

        public ImageSource DurianImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.durian.png"); }
        }

        public ImageSource KakaoImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.kakao.png"); }
        }

        public ImageSource PromoImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.promo.jpg"); }
        }
    }
}
