using System;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace XPrototype
{
	public class Shop : INotifyPropertyChanged
	{
		public string ShopName { get; set; }

		public string Desc { get; set; }

	    public string ImageUrl { get; set; }
		

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string name)
		{
			if (PropertyChanged == null)
				return;
			PropertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}
}

