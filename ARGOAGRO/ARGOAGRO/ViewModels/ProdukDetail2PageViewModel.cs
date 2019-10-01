using ARGOAGRO.ViewModels.Presentation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class ProdukDetail2PageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;

        private ProductViewModel _product;
        public ProductViewModel Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }

        private bool _isFirstOn;
        public bool IsFirstOn
        {
            get { return _isFirstOn; }
            set { SetProperty(ref _isFirstOn, value); }
        }

        private bool _isSecondOn;
        public bool IsSecondOn
        {
            get { return _isSecondOn; }
            set { SetProperty(ref _isSecondOn, value); }
        }

        private bool _isThirdOn;
        public bool IsThirdOn
        {
            get { return _isThirdOn; }
            set { SetProperty(ref _isThirdOn, value); }
        }

        private bool _isFourthOn;
        public bool IsFourthOn
        {
            get { return _isFourthOn; }
            set { SetProperty(ref _isFourthOn, value); }
        }


        private bool _isFifthOn;
        public bool IsFifthOn
        {
            get { return _isFifthOn; }
            set { SetProperty(ref _isFifthOn, value); }
        }


        // Boolean for set the correspondence stars off
        private bool _isFirstOff;
        public bool IsFirstOff
        {
            get { return _isFirstOff; }
            set { SetProperty(ref _isFirstOff, value); }
        }

        private bool _isSecondOff;
        public bool IsSecondOff
        {
            get { return _isSecondOff; }
            set { SetProperty(ref _isSecondOff, value); }
        }

        private bool _isThirdOff;
        public bool IsThirdOff
        {
            get { return _isThirdOff; }
            set { SetProperty(ref _isThirdOff, value); }
        }

        private bool _isFourthOff;
        public bool IsFourthOff
        {
            get { return _isFourthOff; }
            set { SetProperty(ref _isFourthOff, value); }
        }

        private bool _isFifthOff;
        public bool IsFifthOff
        {
            get { return _isFifthOff; }
            set { SetProperty(ref _isFifthOff, value); }
        }

        public ProdukDetail2PageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;

        }

        public override void OnNavigatedTo(INavigationParameters param)
        {
            if (!param.ContainsKey("productType")) return;

            Product = param.GetValue<ProductViewModel>("productType");
            setStarsOn();

        }

        /// <summary>
        /// Set stars on for the rating of the product
        /// </summary>
        private void setStarsOn()
        {
            Debug.WriteLine("hahaha rating: " + Product.Rating);

            if (Product.Rating >= 1) IsFirstOn = true; else IsFirstOff = true;

            if (Product.Rating >= 2) IsSecondOn = true; else IsSecondOff = true;

            if (Product.Rating >= 3) IsThirdOn = true; else IsThirdOff = true;

            if (Product.Rating >= 4) IsFourthOn = true; else IsFourthOff = true;

            if (Product.Rating >= 5) IsFifthOn = true; else IsFifthOff = true;
        }

        // Image Source

        public ImageSource StarOnImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.star-48-on.png"); }
        }
        public ImageSource StarOffImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.star-48-off.png"); }
        }
    }
}
