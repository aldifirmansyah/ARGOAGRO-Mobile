using ARGOAGRO.ViewModels.Presentation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ARGOAGRO.ViewModels
{
	public class PreorderPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;

        private ProductViewModel _product;
        public ProductViewModel Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }
        private int _orderQuantity;
        public int OrderQuantity
        {
            get { return _orderQuantity; }
            set { SetProperty(ref _orderQuantity, value); }
        }

        private int _subtotal;
        public int Subtotal
        {
            get { return _subtotal; }
            set { SetProperty(ref _subtotal, value); }
        }

        private string _subtotalStr;
        public string SubtotalStr
        {
            get { return _subtotalStr; }
            set { SetProperty(ref _subtotalStr, value); }
        }

        public DelegateCommand EnterShoppingCartCommand => new DelegateCommand(() =>
        {
            _navigationService.NavigateAsync("/MainPage/NavigationPage/HomePage");
        });

        public DelegateCommand<string> IsAddQuantityCommand => new DelegateCommand<string>((opr) =>
        {
            if (opr == "add")
            {
                OrderQuantity++;
                updateSubtotal();
            }
            else if (OrderQuantity > 0)
            {
                OrderQuantity--;
                updateSubtotal();
            }
        });

        public PreorderPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            SubtotalStr = "Rp0";
        }

        public override void OnNavigatedTo(INavigationParameters param)
        {
            if (!param.ContainsKey("theProduct")) return;

            Product = param.GetValue<ProductViewModel>("theProduct");
        }

        private void updateSubtotal()
        {
            Subtotal = Product.UnitPrice * OrderQuantity;
            SubtotalStr = String.Format("Rp{0:n0}", Subtotal).Replace(",", ".");
        }
    }
}
