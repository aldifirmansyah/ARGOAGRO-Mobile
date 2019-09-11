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
                    ImageName = "kakao.png",
                    Name = "PERKEBUNAN"
                },
                new ProductTypeViewModel()
                {
                    ID = 4,
                    ImageName = "promo.jpg"
                    Name = "Promo"
                }
            };
            return result;
        }

        public IEnumerable<ProductViewModel> GetAllProduct()
        {
            IEnumerable<ProductViewModel> result = new List<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    ID = 1,
                    TypeID = 1,
                    ImageName = "beras.png",
                    ProductName = "Beras",
                    ProductBrand = "Brand Cap Bunga",
                    Description = "Beras Brand Cap Bunga merupakan beras yang tidak memakai bahan pemutih, tidak memakai bahan pengawet, " +
                    "dan tidak memakai bahan pewangi. Beras ini cocok untuk kalangan menengah dengan harga ekonomis.",
                    Rating = 4,
                    UnitPrice = 55000,
                    UnitType = "pack",
                    TotalReview = 350,
                    TotalSold = 733,
                    ProductCode = "B1256",
                    Terms = "Minimal pembelian 1 pack"
                },
                new ProductViewModel()
                {
                    ID = 2,
                    TypeID = 2,
                    ImageName = "durian.png",
                    ProductName = "Durian",
                    ProductBrand = "Brand kembang kuning",
                    Description = "Brand Kembang Kuning menghasilkan durian yang didapat langsung dari petani berkualitas. " +
                    "Dijamin manis dengan harga yang terjangkau.",
                    Rating = 5,
                    UnitPrice = 25000,
                    UnitType = "kg",
                    TotalReview = 654,
                    TotalSold = 1134,
                    ProductCode = "D3324",
                    Terms = "Minimal pembelian Rp50.000"
                },
                new ProductViewModel()
                {
                    ID = 3,
                    TypeID = 3,
                    ImageName = "kakao.png",
                    ProductName = "Kakao",
                    ProductBrand = "Brand Terang Bulan",
                    Description = "Berasal dari biji kakao polman, salah satu biji kakao terbaik di Indonesia. Dijamin memiliki " +
                    "rasa yang nikmat jika diolah menjadi coklat.",
                    Rating = 4,
                    UnitPrice = 30000,
                    UnitType = "kg",
                    TotalReview = 220,
                    TotalSold = 546,
                    ProductCode = "K9844",
                    Terms = "Minimal pembelian 5 kg"
                },
                new ProductViewModel()
                {
                    ID = 4,
                    TypeID = 4,
                    ImageName = "nanas.png",
                    ProductName = "Nanas",
                    ProductBrand = "Brand Subang",
                    Description = "Nanas muda hutan dengan harga terjangkau.",
                    Rating = 3,
                    UnitPrice = 75000,
                    UnitType = "kg",
                    TotalReview = 220,
                    TotalSold = 546,
                    ProductCode = "N6244",
                    Terms = "Minimal pembelian 1 kg",
                    Discount = 20
                }
            };
            return result;
        }
    }
}
