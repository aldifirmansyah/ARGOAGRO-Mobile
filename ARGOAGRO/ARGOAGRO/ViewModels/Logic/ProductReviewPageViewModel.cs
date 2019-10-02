using ARGOAGRO.Services;
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
	public class ProductReviewPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;
        private ProductService productService = new ProductService();  

        private ProductViewModel _product;
        public ProductViewModel Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }

        private IEnumerable<ProductReviewViewModel> _productReviews;
        public IEnumerable<ProductReviewViewModel> ProductReviews
        {
            get { return _productReviews; }
            set { SetProperty(ref _productReviews, value); }
        }

        private ProductReviewViewModel _productReview;
        public ProductReviewViewModel ProductReview
        {
            get { return _productReview; }
            set { SetProperty(ref _productReview, value); }
        }

        public ProductReviewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            setupStars();
        }

        public override void OnNavigatedTo(INavigationParameters param)
        {
            if (!param.ContainsKey("theProduct")) return;

            Product = param.GetValue<ProductViewModel>("theProduct");
            setProductReview();
            
        }

        private void setupStars()
        {
            IsFirstOff = true;
            IsSecondOff = true;
            IsThirdOff = true;
            IsFourthOff = true;
            IsFifthOff = true;
        }

        private async void setProductReview()
        {
            ProductReviews = await productService.GetProductReviewByProductID(Product.ID);
            

            ProductReview = ProductReviews.ElementAt(0);
            setRatingStars();
        }

        private void setRatingStars()
        {
            if (ProductReview.Rating >= 1) IsRatingOne = true; else return;

            if (ProductReview.Rating >= 2) IsRatingTwo = true; else return;

            if (ProductReview.Rating >= 3) IsRatingThree = true; else return;

            if (ProductReview.Rating >= 4) IsRatingFour = true; else return;

            if (ProductReview.Rating >= 5) IsRatingFive = true; else return;
        }


        // Boolean for set the correspondence stars off
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
        
        // Boolean for setting the review rating
        private bool _isRatingOne;
        public bool IsRatingOne
        {
            get { return _isRatingOne; }
            set { SetProperty(ref _isRatingOne, value); }
        }

        private bool _isRatingTwo;
        public bool IsRatingTwo
        {
            get { return _isRatingTwo; }
            set { SetProperty(ref _isRatingTwo, value); }
        }

        private bool _isRatingThree;
        public bool IsRatingThree
        {
            get { return _isRatingThree; }
            set { SetProperty(ref _isRatingThree, value); }
        }

        private bool _isRatingFour;
        public bool IsRatingFour
        {
            get { return _isRatingFour; }
            set { SetProperty(ref _isRatingFour, value); }
        }

        private bool _isRatingFive;
        public bool IsRatingFive
        {
            get { return _isRatingFive; }
            set { SetProperty(ref _isRatingFive, value); }
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
