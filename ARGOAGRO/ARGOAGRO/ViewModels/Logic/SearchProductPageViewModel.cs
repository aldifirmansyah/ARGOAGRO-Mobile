using ARGOAGRO.Services;
using ARGOAGRO.ViewModels.Presentation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
    public class SearchProductPageViewModel : ViewModelBase
    {
        public ImageSource MapImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.map.png"); }
        }

        public ImageSource StoreImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.cari_produk_icon.png"); }
        }

        public ImageSource SearchIcon
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.search_icon.png"); }
        }

        private bool _berasResultVisibility;
        public bool BerasResultVisibility
        {
            get { return _berasResultVisibility; }
            set { SetProperty(ref _berasResultVisibility, value); }
        }

        private bool _kakaoResultVisibility;
        public bool KakaoResultVisibility
        {
            get { return _kakaoResultVisibility; }
            set { SetProperty(ref _kakaoResultVisibility, value); }
        }

        private bool _durianResultVisibility;
        public bool DurianResultVisibility
        {
            get { return _durianResultVisibility; }
            set { SetProperty(ref _durianResultVisibility, value); }
        }

        public string SearchText { get; set; }

        private DelegateCommand _searchCommand;
        public DelegateCommand SearchCommand => _searchCommand ?? (_searchCommand = new DelegateCommand(SubmitSearch));

        private DelegateCommand _searchIconClickedCommand;
        public DelegateCommand SearchIconClicked => _searchIconClickedCommand ?? (_searchIconClickedCommand = new DelegateCommand(SubmitSearch));

        public void SubmitSearch()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                BerasResultVisibility = false;
                KakaoResultVisibility = false;
                DurianResultVisibility = false;
                return;
            }
            string val = SearchText.Trim().ToLower();
            if (val == "beras")
            {
                BerasResultVisibility = true;
                KakaoResultVisibility = false;
                DurianResultVisibility = false;
            }
            else if (val == "kakao")
            {
                BerasResultVisibility = false;
                KakaoResultVisibility = true;
                DurianResultVisibility = false;
            }
            else if (val == "durian")
            {
                BerasResultVisibility = false;
                KakaoResultVisibility = false;
                DurianResultVisibility = true;
            }
            else
            {
                BerasResultVisibility = false;
                KakaoResultVisibility = false;
                DurianResultVisibility = false;
                _pageDialogService.DisplayAlertAsync("Alert", SearchText + " not found.", "OK");
            }

        }

        private IEnumerable<ProductViewModel> _allProducts;
        public IEnumerable<ProductViewModel> AllProducts
        {
            get { return _allProducts; }
            set { SetProperty(ref _allProducts, value); }
        }

        private DelegateCommand<string> _locationClickedCommand;
        public DelegateCommand<string> LocationClickedCommand => _locationClickedCommand ?? (_locationClickedCommand = new DelegateCommand<string>(async (type) =>
        {
            await Redirect(type);
        }));
        
        private async Task Redirect(string type)
        {
            var param = new NavigationParameters();
            var key = "productType";

            if (type == "beras") param.Add(key, AllProducts.ElementAt(0));
            else if (type == "durian") param.Add(key, AllProducts.ElementAt(1));
            else if (type == "kakao") param.Add(key, AllProducts.ElementAt(2));
            else param.Add(key, AllProducts.ElementAt(3));

            await _navigationService.NavigateAsync("ProdukDetailPage", param);
        }
        
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;
        private ProductService _productService = new ProductService();

        public SearchProductPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            AllProducts = _productService.GetAllProduct();
        }
	}
}
