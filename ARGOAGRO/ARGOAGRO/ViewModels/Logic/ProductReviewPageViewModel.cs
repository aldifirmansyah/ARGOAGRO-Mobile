﻿using ARGOAGRO.Services;
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

        private String _fullName;
        private String _email;
        private String _location;
        private String _description;
        private int _rating;

        public String FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        public String Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public String Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
        }

        public String Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public int Rating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }

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
            
            foreach (ProductReviewViewModel review in ProductReviews)
            {
                setRatingStars(review);
            }
            
        }

        private void setRatingStars(ProductReviewViewModel review)
        {
            if (review.Rating >= 1) review.IsRatingOne = true; else return;

            if (review.Rating >= 2) review.IsRatingTwo = true; else return;

            if (review.Rating >= 3) review.IsRatingThree = true; else return;

            if (review.Rating >= 4) review.IsRatingFour = true; else return;

            if (review.Rating >= 5) review.IsRatingFive = true; else return;
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
