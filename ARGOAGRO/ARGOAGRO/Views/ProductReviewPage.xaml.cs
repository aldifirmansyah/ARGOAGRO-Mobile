using ARGOAGRO.ViewModels;
using ARGOAGRO.ViewModels.Presentation;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ARGOAGRO.Views
{
    public partial class ProductReviewPage : ContentPage
    {
        /*
        private ProductReviewPageViewModel ProductReviewPageVM
        {
            get { return (ProductReviewPageViewModel) this.BindingContext; }
        }*/
        
        public ProductReviewPage()
        {
            InitializeComponent();
            Debug.WriteLine("hahahahahahaha");
            //var reviews = new List<ProductReviewViewModel>(ProductReviewPageVM.ProductReviews);
            //var x = ProductReviewPageVM.ProductReviews;
            
            //Grid gridReview;

            //Debug.WriteLine("99999999 size: " + reviews.Count);
            /*
            foreach (ProductReviewViewModel review in reviews)
            {
                Debug.WriteLine("999999 name: " + review.FullName);
                // Grid for each review
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

                /*
                // StackLayout for rating
                StackLayout ratingStackLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal
                };
                ratingStackLayout.Children.Add(new Image
                {
                    Source = review.StarOnImg,
                    HeightRequest = 16,
                    IsVisible = review.IsRatingOne
                });
                ratingStackLayout.Children.Add(new Image
                {
                    Source = review.StarOnImg,
                    HeightRequest = 16,
                    IsVisible = review.IsRatingTwo
                });
                ratingStackLayout.Children.Add(new Image
                {
                    Source = review.StarOnImg,
                    HeightRequest = 16,
                    IsVisible = review.IsRatingThree
                });
                ratingStackLayout.Children.Add(new Image
                {
                    Source = review.StarOnImg,
                    HeightRequest = 16,
                    IsVisible = review.IsRatingFour
                });
                ratingStackLayout.Children.Add(new Image
                {
                    Source = review.StarOnImg,
                    HeightRequest = 16,
                    IsVisible = review.IsRatingFive
                });

                Label fullnameLabel = new Label
                {
                    Text = review.FullName,
                    TextColor = Color.FromHex("#95a5a6"),
                    FontSize = 14,
                    FontAttributes = FontAttributes.Bold
                };
                Label locationLabel = new Label
                {
                    Text = review.Location,
                    TextColor = Color.FromHex("95a5a6"),
                    FontSize = 14,
                    FontAttributes = FontAttributes.Bold
                };
                Label descriptionLabel = new Label
                {
                    Text = review.Description,
                    TextColor = Color.FromHex("000000"),
                    FontSize = 12
                };

                // param: view, column, row
                gridReview.Children.Add(ratingStackLayout, 0, 0);
                gridReview.Children.Add(fullnameLabel, 0, 1);
                gridReview.Children.Add(locationLabel, 0, 2);
                gridReview.Children.Add(descriptionLabel, 0, 3);
                

                ReviewsStackLayout.Children.Add(gridReview);
            }
            */
        }
    }
}
