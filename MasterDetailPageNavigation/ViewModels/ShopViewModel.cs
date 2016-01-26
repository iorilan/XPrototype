using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace XPrototype
{
	public class ShopViewModel : BaseViewModel
	{
		public ShopViewModel()
		{
			Title = "Shops";
			Icon = "home1.png";
		}


		private ObservableCollection<Shop> shops = new ObservableCollection<Shop>();

		/// <summary>
		/// gets or sets the feed items
		/// </summary>
		public ObservableCollection<Shop> Shops
		{
			get { return shops; }
			set { shops = value; OnPropertyChanged(); }
		}

		private Shop _selectedShop;
		/// <summary>
		/// Gets or sets the selected feed item
		/// </summary>
		public Shop SelectedShop
		{
			get { return _selectedShop; }
			set
			{
				_selectedShop = value;
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
				return;

			IsBusy = true;
			var error = false;
			try
			{
				var responseString = string.Empty;
				using (var httpClient = new HttpClient())
				{
					var url = "http://xmock.azurewebsites.net/XPrototype/GetShops";
					responseString = await httpClient.GetStringAsync(url);
				}

				Shops.Clear();
				var items = JsonConvert.DeserializeObject<IList<Shop>>(responseString);
				foreach (var item in items)
				{
					Shops.Add(item);
				}
			}
			catch
			{
				error = true;
			}

			if (error)
			{
				var page = new ContentPage();
				await page.DisplayAlert("Error", "Unable to load blog.", "OK");

			}

			IsBusy = false;
		}

		/// <summary>
		/// Gets a specific feed item for an Id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Shop GetFeedItem(int id)
		{
			throw new NotImplementedException();
		}
	}
}

