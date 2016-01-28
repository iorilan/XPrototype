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
		            TargetType = typeof (MyShops)
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
		        }
            };

		    MyListView.ItemsSource = masterPageItems;
		}
	}
}
