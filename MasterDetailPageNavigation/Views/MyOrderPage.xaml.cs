using Xamarin.Forms;

namespace XPrototype
{
	public partial class MyOrderPage : ContentPage
	{
		public MyOrderPage()
		{
			InitializeComponent ();
            BindingContext = new OrderViewModel();
        }

        private OrderViewModel ViewModel
        {
            get { return BindingContext as OrderViewModel; }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.Orders.Count > 0)
                return;

            ViewModel.LoadItemsCommand.Execute(null);
        }

        protected void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Navigation.PushModalAsync(new DetailPage(e.SelectedItem));
        }
    }
}

