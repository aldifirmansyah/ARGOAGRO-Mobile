using ARGOAGRO.Models;
using ARGOAGRO.ViewModels.Presentation;
using ePMPro.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ARGOAGRO.Services
{
    public class ProductService
    {
        private SQLiteAsyncConnection _localDbConnection = DependencyService.Get<ISQLiteDb>().GetConnection();

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
                    ImageName = "promo.jpg",
                    Name = "Promo"
                }
            };
            return result;
        }

        /// <summary>
        /// get all product without stores attribute
        /// </summary>
        /// <returns>IENumerable of ProductViewModel</returns>
        public IEnumerable<ProductViewModel> GetAllProduct()
        {
            IEnumerable<ProductViewModel> result = new List<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    ID = 1,
                    TypeID = 1,
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.beras-512.png"),
                    ProductName = "BERAS",
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
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.durian-512.png"),
                    ProductName = "DURIAN",
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
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.kakao-512.png"),
                    ProductName = "KAKAO",
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
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.nanas-512.png"),
                    ProductName = "NANAS",
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
        
        /// <summary>
        /// Get All Product Review regarding a product using its ID
        /// </summary>
        /// <param name="productID">The ID of a product</param>
        /// <returns>IENumerable of Product ReviewViewModel</returns>
        public async Task<IEnumerable<ProductReviewViewModel>> GetProductReviewByProductID(int productID)
        {
            List<ProductReviewViewModel> productReviewDummies = new List<ProductReviewViewModel>()
            {
                new ProductReviewViewModel()
                {
                    ProductID = 1,
                    FullName = "Intan Dwi Nuraini",
                    Email = "intandwi@gmail.com",
                    Location = "Jakarta",
                    Description = "Barang cepat sampai. Rasa tidak mengecewakan. Masukan untuk brand ini, packing lebih diperbagus " +
                    "karena packing saat sudah sampai sedikit rusak.",
                    Rating = 5
                },
                new ProductReviewViewModel()
                {
                    ProductID = 2,
                    FullName = "Intan Dwi Nuraini",
                    Email = "intandwi@gmail.com",
                    Location = "Jakarta",
                    Description = "Barang cepat sampai. Rasa tidak mengecewakan. Masukan untuk brand ini, packing lebih diperbagus " +
                    "karena packing saat sudah sampai sedikit rusak.",
                    Rating = 4
                },
                new ProductReviewViewModel()
                {
                    ProductID = 3,
                    FullName = "Intan Dwi Nuraini",
                    Email = "intandwi@gmail.com",
                    Location = "Jakarta",
                    Description = "Barang cepat sampai. Rasa tidak mengecewakan. Masukan untuk brand ini, packing lebih diperbagus " +
                    "karena packing saat sudah sampai sedikit rusak.",
                    Rating = 5
                },
                new ProductReviewViewModel()
                {
                    ProductID = 4,
                    FullName = "Intan Dwi Nuraini",
                    Email = "intandwi@gmail.com",
                    Location = "Jakarta",
                    Description = "Barang cepat sampai. Rasa tidak mengecewakan. Masukan untuk brand ini, packing lebih diperbagus " +
                    "karena packing saat sudah sampai sedikit rusak.",
                    Rating = 4
                }
            };
          
            var dummy = new List<ProductReviewViewModel>(productReviewDummies.Where(data => data.ProductID == productID))[0];
            var result = new List<ProductReviewViewModel>();
            result.Add(new ProductReviewViewModel(new ProductReviewModel() {
                ProductID = dummy.ProductID,
                FullName = dummy.FullName,
                Email = dummy.Email,
                Location = dummy.Location,
                Description = dummy.Description,
                Rating = dummy.Rating
        }));

            await _localDbConnection.CreateTableAsync<ProductReviewModel>();
            var productReviewModels = await _localDbConnection.Table<ProductReviewModel>().Where(data => data.ProductID == productID).ToListAsync();
            foreach (ProductReviewModel obj in productReviewModels)
            {
                result.Add(new ProductReviewViewModel(obj));
            }

            return result;
        }

        public async Task CreateProductReview(ProductReviewViewModel obj)
        {
            await _localDbConnection.CreateTableAsync<ProductReviewModel>();
            ProductReviewModel productReviewModel = new ProductReviewModel()
            {
                ProductID = obj.ProductID,
                FullName = obj.FullName,
                Email = obj.Email,
                Location = obj.Location,
                Description = obj.Description,
                Rating = obj.Rating
            };
            await _localDbConnection.InsertAsync(productReviewModel);
        }
        
    }
}
