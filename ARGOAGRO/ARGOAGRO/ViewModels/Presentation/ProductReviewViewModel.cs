using System;
using System.Collections.Generic;
using System.Text;

namespace ARGOAGRO.ViewModels.Presentation
{
    class ProductReviewViewModel
    {
        public string ProductID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
