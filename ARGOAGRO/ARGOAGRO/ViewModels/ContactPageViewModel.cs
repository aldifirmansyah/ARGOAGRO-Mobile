using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class ContactPageViewModel : BindableBase
	{
        public ContactPageViewModel()
        {

        }

        public ImageSource ContactImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.kontak_kami_header.jpg"); }
        }

        public ImageSource PhoneImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.call.png"); }
        }

    }
}
