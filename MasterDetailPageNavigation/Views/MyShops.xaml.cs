using Xamarin.Forms;

namespace XPrototype
{
	public partial class MyShops : ContentPage
	{
		public MyShops()
		{
			InitializeComponent ();
            BindingContext = new ShopViewModel();
        }

        private ShopViewModel ViewModel
        {
            get { return BindingContext as ShopViewModel; }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.Shops.Count > 0)
                return;

            ViewModel.LoadItemsCommand.Execute(null);
        }

        protected void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushModalAsync(new DetailPage(e.SelectedItem));
        }
    }
}

