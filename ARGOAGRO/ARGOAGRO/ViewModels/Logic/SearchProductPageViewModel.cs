using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class SearchProductPageViewModel : BindableBase
	{
        public ImageSource MapImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.map.png"); }
        }

        public SearchProductPageViewModel()
        {

        }
	}
}
