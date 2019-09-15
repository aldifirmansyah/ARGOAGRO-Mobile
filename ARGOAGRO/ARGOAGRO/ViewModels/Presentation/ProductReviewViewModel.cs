using ARGOAGRO.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
        }
    }
}
