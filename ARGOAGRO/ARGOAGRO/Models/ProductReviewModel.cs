using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARGOAGRO.Models
{
    public class ProductReviewModel
    {
        [PrimaryKey]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
