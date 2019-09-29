using ARGOAGRO.Services;
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
	public class ProdukPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        
        private ProductService _productService = new ProductService();
        
        private IEnumerable<ProductViewModel> _allProducts;

        public IEnumerable<ProductViewModel> AllProducts
        {
            get { return _allProducts; }
            set { SetProperty(ref _allProducts, value); }
        }

        public DelegateCommand<String> ProductDetailCommand => new DelegateCommand<String>(async (productType) =>
        {
            Debug.WriteLine("ProductDetailCommand IS CALLED!");
            var param = new NavigationParameters();
            var key = "productType";

            if (productType == "beras") param.Add(key, AllProducts.ElementAt(0));
            else if (productType == "durian") param.Add(key, AllProducts.ElementAt(1));
            else if (productType == "kakao") param.Add(key, AllProducts.ElementAt(2));
            else param.Add(key, AllProducts.ElementAt(3));

            await _navigationService.NavigateAsync("ProdukDetailPage", param);
        });
        
        

        public ProdukPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;

            //AllProducts = _productService.GetAllProduct();
            
            AllProducts = new List<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    ID = 1,
                    TypeID = 1,
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.padi.png"),
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
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.durian.png"),
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
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.kakao.png"),
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
                    ImageName = ImageSource.FromResource("ARGOAGRO.Img.nanas.png"),
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
        }



        public ImageSource PadiImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.padi.png"); }
        }

        public ImageSource DurianImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.durian.png"); }
        }

        public ImageSource KakaoImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.kakao.png"); }
        }

        public ImageSource PromoImg
        {
            get { return ImageSource.FromResource("ARGOAGRO.Img.promo.jpg"); }
        }
    }
}
