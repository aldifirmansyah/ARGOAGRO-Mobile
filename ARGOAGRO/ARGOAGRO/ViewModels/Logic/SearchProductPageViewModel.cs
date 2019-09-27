using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        private DelegateCommand<string> _locationClickedCommand;
        public DelegateCommand<string> LocationClickedCommand => _locationClickedCommand ?? (_locationClickedCommand = new DelegateCommand<string>(Redirect));
        
        private void Redirect(string type)
        {
            _pageDialogService.DisplayAlertAsync("Alert", type + " invoked!", "OK");
        }
        
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;

        public SearchProductPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }
	}
}
