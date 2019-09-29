using ARGOAGRO.Services;
using ARGOAGRO.ViewModels.Presentation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class ProdukDetailPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;
        private ProductService _productService = new ProductService();

        private ProductViewModel _product;
        public ProductViewModel Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }

        // Boolean for set the correspondence stars on
        public bool IsFirstOn { get; set; } = false;
        public bool IsSecondOn { get; set; } = false;
        public bool IsThirdOn { get; set; } = false;
        public bool IsFourthOn { get; set; } = false;
        public bool IsFifthOn { get; set; } = false;

        // Boolean for set the correspondence stars off
        public bool IsFirstOff { get; set; } = false;
        public bool IsSecondOff { get; set; } = false;
        public bool IsThirdOff { get; set; } = false;
        public bool IsFourthOff { get; set; } = false;
        public bool IsFifthOff { get; set; } = false;

        public ProdukDetailPageViewModel(INavigationService navigationService) : base(navigationService)
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
            if (Product.Rating >= 1) IsFirstOn = true;
            else { IsFirstOff = true; return; }

            if (Product.Rating >= 2) IsSecondOn = true;
            else { IsSecondOff = true; return; }

            if (Product.Rating >= 3) IsThirdOn = true;
            else { IsThirdOff = true; return; }

            if (Product.Rating >= 4) IsFourthOn = true;
            else { IsFourthOff = true; return; }

            if (Product.Rating >= 5) IsFifthOn = true;
            else { IsFifthOff = true; return; }
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
