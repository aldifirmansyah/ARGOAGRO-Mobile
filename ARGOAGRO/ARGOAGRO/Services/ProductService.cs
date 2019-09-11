using ARGOAGRO.ViewModels.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARGOAGRO.Services
{
    public class ProductService
    {
        /// <summary>
        /// Get all product type
        /// </summary>
        /// <returns>IENumerable of ProductTypeViewModel</returns>
        public IEnumerable<ProductTypeViewModel> GetAllProductType()
        {
            IEnumerable<ProductTypeViewModel> result = new List<ProductTypeViewModel>() {
                new ProductTypeViewModel()
                {
                    ID = 1,
                    ImageName = "padi.png",
                    Name = "TANAMAN PANGAN"
                },
                new ProductTypeViewModel()
                {
                    ID = 2,
                    ImageName = "durian.png",
                    Name = "TANAMAN HORTIKULTURA"
                },
                new ProductTypeViewModel()
                {
                    ID = 3,
                    ImageName = "kokoa.png",
                    Name = "PERKEBUNAN"
                }
            };
            return result;
        }
    }
}
