using System.Collections.Generic;
using Xamarin.Forms;

namespace XPrototype
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return MyListView; } }

		public MasterPage ()
		{
			InitializeComponent ();

		    var masterPageItems = new List<MasterPageItem>
		    {
		        new MasterPageItem
		        {
		            Title = "Shops",
		            IconSource = "shop.png",
		            TargetType = typeof (ShopsPage)
		        },
		        new MasterPageItem
		        {
		            Title = "Settings",
		            IconSource = "settings.png",
		            TargetType = typeof (SettingsPage)
		        },
		        new MasterPageItem
		        {
		            Title = "My Orders",
		            IconSource = "my_order.png",
		            TargetType = typeof (MyOrderPage)
		        },
                new MasterPageItem
                {
                    Title = "Shop Page",
                    IconSource = "home1.png",
                    TargetType = typeof (ShopPage)
                }
            };

		    MyListView.ItemsSource = masterPageItems;
		}
	}
}
