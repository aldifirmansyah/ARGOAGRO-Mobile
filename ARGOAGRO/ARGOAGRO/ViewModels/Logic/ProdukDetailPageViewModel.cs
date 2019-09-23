using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class ProdukDetailPageViewModel : BindableBase
	{
        private readonly INavigationService _navigationService;

        public ImageSource BerasImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.beras.png"); }
        }

        public ProdukDetailPageViewModel()
        {
        }
	}
}
