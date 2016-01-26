using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XPrototype
{
	public partial class ShopsPage : ContentPage
	{
		public ShopsPage()
		{
			InitializeComponent ();
			nativeListView.Items = DataSource.GetList ();
		}

		async void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			await Navigation.PushModalAsync (new DetailPage (e.SelectedItem));
		}
	}

    public class NativeListView : ListView
    {
        public static readonly BindableProperty ItemsProperty =
            BindableProperty.Create("Items", typeof(IEnumerable<DataSource>), typeof(NativeListView), new List<DataSource>());

        public IEnumerable<DataSource> Items
        {
            get { return (IEnumerable<DataSource>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
            }
        }
    }

    public class DataSource
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string ImageFilename { get; set; }

        public DataSource(string name, string category, string imageFilename)
        {
            Name = name;
            Category = category;
            ImageFilename = imageFilename;
        }

        public static List<DataSource> GetList()
        {
            var l = new List<DataSource>();

            l.Add(new DataSource("Serangoon house", "SPA", "home1"));
            l.Add(new DataSource("Orchard house", "SPA", "home2"));
            l.Add(new DataSource("best SPA", "SPA", "home3"));
            l.Add(new DataSource("best SPA2", "SPA", "home4"));
            l.Add(new DataSource("best SPA3", "SPA", "home5"));

            return l;
        }
    }
}

