using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class QuestionPageViewModel : BindableBase
	{
        public QuestionPageViewModel()
        {

        }

        public ImageSource QuestionImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.pertanyaan_header.jpg"); }
        }
    }
}
