using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class ProdukPageViewModel : BindableBase
	{
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
            get { return ImageSource.FromResource("ARGOAGRO.Img.promo.png"); }
        }

        public ProdukPageViewModel()
        {

        }
	}
}
