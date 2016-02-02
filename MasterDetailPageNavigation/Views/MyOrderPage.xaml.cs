using System;
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

	    private void BtnReorder_OnClicked(object sender, EventArgs e)
	    {
	        var btn = sender as Button;
	        if (btn != null)
	        {
                var parent = btn.Parent as StackLayout;
	            if (parent != null)
	            {
	                var shopName = parent.Children[0] as Label;
	                var time = parent.Children[1] as Label;

                    //TODO : insert order record here

                    DisplayAlert("Message", string.Format("you have reordered shop :{0} service for time range : {1}.", shopName.Text, time.Text), "OK");
                }
	        }
	    }
	}
}

