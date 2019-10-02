using ARGOAGRO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels.Presentation
{
    public class ProductReviewViewModel
    {
        public int ProductID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public bool IsRatingOne { get; set; }
        public bool IsRatingTwo { get; set; }
        public bool IsRatingThree { get; set; }
        public bool IsRatingFour { get; set; }
        public bool IsRatingFive { get; set; }


        public ProductReviewViewModel() { }

        public ProductReviewViewModel(ProductReviewModel obj)
        {
            ProductID = obj.ProductID;
            FullName = obj.FullName;
            Email = obj.Email;
            Location = obj.Location;
            Description = obj.Location;
            Description = obj.Description;
            Rating = obj.Rating;


            //setRatingStars(obj);
        }

        

        public ImageSource StarOnImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.star-48-on.png"); }
        }

        /*
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
        } */
    }
}
