using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ARGOAGRO.ViewModels.Presentation
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public int TypeID { get; set; }
        public ImageSource ImageName { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int UnitPrice { get; set; }
        public string UnitType { get; set; }
        public int TotalReview { get; set; }
        public int TotalSold { get; set; }
        public string ProductCode { get; set; }
        public string Terms { get; set; }
        public IEnumerable<StoreViewModel> Stores { get; set; }
        public int Discount { get; set; }

        public string Price {
            get { return String.Format("{0:n0}", UnitPrice).Replace(",", "."); ; }        
        }
    }
}
