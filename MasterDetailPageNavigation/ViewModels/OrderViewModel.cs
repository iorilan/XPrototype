using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json;
using Xamarin.Forms;
using XPrototype.Models;

namespace XPrototype
{
	public class OrderViewModel : BaseViewModel
	{
		public OrderViewModel()
		{
			Title = "My Orders";
		}


		private ObservableCollection<Order> orders = new ObservableCollection<Order>();

		/// <summary>
		/// gets or sets the feed items
		/// </summary>
		public ObservableCollection<Order> Orders
		{
			get { return orders; }
			set { orders = value; OnPropertyChanged(); }
		}

		private Order _selectedOrder;
		/// <summary>
		/// Gets or sets the selected feed item
		/// </summary>
		public Order SelectedOrder
		{
			get { return _selectedOrder; }
			set
			{
				_selectedOrder = value;
				OnPropertyChanged();
			}
		}

		private Command loadItemsCommand;
		/// <summary>
		/// Command to load/refresh items
		/// </summary>
		public Command LoadItemsCommand
		{
			get { return loadItemsCommand ?? (loadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand())); }
		}

		private async Task ExecuteLoadItemsCommand()
		{
		    if (IsBusy)
		    {
                return;
            }

			IsBusy = true;
			var error = false;
			try
			{
                //var responseString = string.Empty;
                //using (var httpClient = new HttpClient())
                //{
                //	responseString = await httpClient.GetStringAsync(ServiceUrls.GetShops);
                //}
                //var items = JsonConvert.DeserializeObject<IList<Shop>>(responseString);
			    var items = DummyService.GetOrders();

                Orders.Clear();
				foreach (var item in items)
				{
                    Orders.Add(item);
				}
			}
			catch
			{
				error = true;
			}

			if (error)
			{
				var page = new ContentPage();
				await page.DisplayAlert("Error", "Unable to load orders.", "OK");

			}

			IsBusy = false;
		}
	}
}

