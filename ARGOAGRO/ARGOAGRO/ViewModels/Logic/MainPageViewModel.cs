using ARGOAGRO.ViewModels.Presentation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ARGOAGRO.ViewModels
{
	public class MainPageViewModel : ViewModelBase
    {
        private readonly IPageDialogService _pageDialogService;
        private readonly INavigationService _navigationService;

        public ObservableCollection<MasterItemViewModel> MasterItems { get; set; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            _pageDialogService = pageDialogService;
            _navigationService = navigationService;

            MasterItems = new ObservableCollection<MasterItemViewModel>(new[]
            {
                new MasterItemViewModel { Title = "HOME", PageName = "HomePage" },
                new MasterItemViewModel { Title = "PRODUK" },
                new MasterItemViewModel { Title = "PENDAFTARAN AKUN" },
                new MasterItemViewModel { Title = "PERTANYAAN" },
                new MasterItemViewModel { Title = "KONTAK KAMI" },
                new MasterItemViewModel { Title = "CARI LOKASI" }
            });
        }
	}
}
