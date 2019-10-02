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

        // transfer img
        public ImageSource BcaImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.bca.png"); }
        }

        public ImageSource BniImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.bni.jpg"); }
        }

        public ImageSource MandiriImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.mandiri.jpg"); }
        }

        // payment
        public ImageSource VisaImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.visa.png"); }
        }

        public ImageSource MastercardImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.mastercard.png"); }
        }

        // sending method
        public ImageSource TikiImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.tiki.png"); }
        }

        public ImageSource JneImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.jne.png"); }
        }

        // media
        public ImageSource SindoImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.sindonews.png"); }
        }
    }
}
