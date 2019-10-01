using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        

        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand BeliSekarangCommand => new DelegateCommand(() =>
        {
            Debug.WriteLine("BELI SEKARANG IS TAPPED!");
            _navigationService.NavigateAsync("/MainPage/NavigationPage/ProdukPage");
        });

        public string Description
        {
            get
            {
                return "ARGOAGRO merupakan aplikasi smart government berbasis WebGIS yang memiliki cara kerja seperti e-commerce " +
                  "dengan fokus menjual produk-produk pertanian baik barang mentah maupun hasil olahan. " +
                  "GIS digunakan sebagai Decision Support System bagi pelaku usaha karena dapat melakukan " +
                  "mapping, routing, dan optimasi logistik berdasarkan peta yang dihasilkan. " +
                  "Bagi pemerintah GIS dapat digunakan untuk memetakan wilayah-wilayah " +
                  "yang potensional untuk memasarkan produk - produk pertanian di kabupaten Madiun dan sekitarnya.";
            }
        }

        public ImageSource LogoImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.logo-onehalf.png"); }
        }

        public ImageSource TasBelanjaImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.tas_belanja.png"); }
        }

        public ImageSource BagusImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.bagus.png"); }
        }

        public ImageSource AnekaBuahImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.aneka_buah.png"); }
        }
    }
}
