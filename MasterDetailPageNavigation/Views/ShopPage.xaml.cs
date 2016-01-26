using Xamarin.Forms;

namespace XPrototype
{
	public partial class ShopPage : ContentPage
	{
		private ShopViewModel ViewModel
		{
			get { return BindingContext as ShopViewModel; }
		}


		public ShopPage()
		{
			InitializeComponent();
			BindingContext = new ShopViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.Shops.Count > 0)
				return;

			ViewModel.LoadItemsCommand.Execute(null);
		}
	}
}

