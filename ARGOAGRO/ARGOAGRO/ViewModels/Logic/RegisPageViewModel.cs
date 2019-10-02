using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class RegisPageViewModel : BindableBase
	{
        public RegisPageViewModel()
        {

        }

        public ImageSource RegisImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.daftar_akun_header.jpg"); }
        }
	}
}
