﻿using ARGOAGRO.Services;
using ARGOAGRO.ViewModels.Presentation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels
{
	public class ProductReviewPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;
        private ProductService productService = new ProductService();
        private ProductViewModel _product;
        private IEnumerable<ProductReviewViewModel> _productReviews;

        private String _fullName;
        private String _email;
        private String _location;
        private String _description;
        private int _rating;

        private bool _isFirstOn;
        private bool _isSecondOn;
        private bool _isThirdOn;
        private bool _isFourthOn;
        private bool _isFifthOn;

        private bool _isFirstOff;
        private bool _isSecondOff;
        private bool _isThirdOff;
        private bool _isFourthOff;
        private bool _isFifthOff;

        // objects to be processed
        public ProductViewModel Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }

        public IEnumerable<ProductReviewViewModel> ProductReviews
        {
            get { return _productReviews; }
            set { SetProperty(ref _productReviews, value); }
        }

        // Product Review Attributes
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

        // Boolean for set the correspondence stars off
        public bool IsFirstOn
        {
            get { return _isFirstOn; }
            set { SetProperty(ref _isFirstOn, value); }
        }
        public bool IsSecondOn
        {
            get { return _isSecondOn; }
            set { SetProperty(ref _isSecondOn, value); }
        }
        public bool IsThirdOn
        {
            get { return _isThirdOn; }
            set { SetProperty(ref _isThirdOn, value); }
        }
        public bool IsFourthOn
        {
            get { return _isFourthOn; }
            set { SetProperty(ref _isFourthOn, value); }
        }
        public bool IsFifthOn
        {
            get { return _isFifthOn; }
            set { SetProperty(ref _isFifthOn, value); }
        }

        // Boolean for set the correspondence stars off
        public bool IsFirstOff
        {
            get { return _isFirstOff; }
            set { SetProperty(ref _isFirstOff, value); }
        }
        public bool IsSecondOff
        {
            get { return _isSecondOff; }
            set { SetProperty(ref _isSecondOff, value); }
        }
        public bool IsThirdOff
        {
            get { return _isThirdOff; }
            set { SetProperty(ref _isThirdOff, value); }
        }
        public bool IsFourthOff
        {
            get { return _isFourthOff; }
            set { SetProperty(ref _isFourthOff, value); }
        }
        public bool IsFifthOff
        {
            get { return _isFifthOff; }
            set { SetProperty(ref _isFifthOff, value); }
        }

        public DelegateCommand SubmitReviewCommand => new DelegateCommand(async () =>
        {
            await SubmitReview();
        });

        public ProductReviewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            setupStars();
        }

        public override void OnNavigatedTo(INavigationParameters param)
        {
            if (!param.ContainsKey("theProduct")) return;

            Product = param.GetValue<ProductViewModel>("theProduct");
            populateReviews();
            
        }

        private void setupStars()
        {
            IsFirstOff = true;
            IsSecondOff = true;
            IsThirdOff = true;
            IsFourthOff = true;
            IsFifthOff = true;
        }

        private async void populateReviews()
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

        async Task SubmitReview()
        {
            ProductReviewViewModel newReview = new ProductReviewViewModel()
            {
                ProductID = Product.ID,
                FullName = this.FullName,
                Email = this.Email,
                Location = this.Location,
                Description = this.Description,
                Rating = 4
            };

            await productService.CreateProductReview(newReview);
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
