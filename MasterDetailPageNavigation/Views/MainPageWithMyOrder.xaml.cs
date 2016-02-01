using System;
using Xamarin.Forms;

namespace XPrototype
{
	public partial class MainPagewithMyOrder : MasterDetailPage
	{
		public MainPagewithMyOrder()
		{
			InitializeComponent ();

		    if (Detail == null)
		    {
		        Detail = new MyShops();
		    }

            MyMasterPage.ListView.ItemSelected += OnItemSelected;
		}

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                MyMasterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
