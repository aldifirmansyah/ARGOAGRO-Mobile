using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public string Description
        {
            get {
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

        public ImageSource AnekaBuahImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.aneka_buah.png"); }
        }

        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
