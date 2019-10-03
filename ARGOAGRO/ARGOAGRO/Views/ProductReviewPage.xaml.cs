using ARGOAGRO.ViewModels;
using ARGOAGRO.ViewModels.Presentation;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ARGOAGRO.Views
{
    public partial class ProductReviewPage : ContentPage
    {
        private ProductReviewPageViewModel ProductReviewPageVM
        {
            get { return (ProductReviewPageViewModel) this.BindingContext; }
        }

        public ProductReviewPage()
        {
            InitializeComponent();

            IEnumerable<ProductReviewViewModel> reviews = ProductReviewPageVM.ProductReviews;
            Grid gridReview;

            foreach (ProductReviewViewModel review in reviews)
            {
                gridReview = new Grid();

                // Grid Appearance
                gridReview.RowSpacing = 0;
                gridReview.VerticalOptions = LayoutOptions.EndAndExpand;
                gridReview.Padding = new Thickness(0, 10, 0, 10);
                gridReview.BackgroundColor = Color.FromHex("ffffff");

                // Row and Column Definitions
                gridReview.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                gridReview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                gridReview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                gridReview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                gridReview.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

                ReviewsStackLayout.Children.Add(gridReview);
            }
            
        }
    }
}
