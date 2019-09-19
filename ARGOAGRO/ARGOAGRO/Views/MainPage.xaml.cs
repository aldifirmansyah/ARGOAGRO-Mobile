using ARGOAGRO.ViewModels;
using Xamarin.Forms;

namespace ARGOAGRO.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private MainPageViewModel MainPageVM
        {
            get { return (MainPageViewModel)this.BindingContext; }
        }

        private void MasterItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MainPageVM.MenuItemClickedCommand.Execute();
        }
    }
}