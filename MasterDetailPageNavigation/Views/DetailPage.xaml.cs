using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Globalization;

namespace XPrototype
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage (object detail)
		{
			InitializeComponent ();

			var buttonGroupMovieStartTimesItems = new List<string>();
		    for (var i = 9; i < 21; i++)
		    {
		        buttonGroupMovieStartTimesItems.Add(string.Format("{0}:00 - {1}:00", i, i+1));
		    }

			var buttonGroupMovieStartTimes = new ButtonGroup
			{
				Rounded = true,
				IsNumber = false,
				ViewBackgroundColor = Color.Black,
				BackgroundColor = Color.Silver,
				TextColor = Color.White,
				BorderColor = Color.White,
				OutlineColor = Color.Black,
				SelectedBackgroundColor = Color.Silver,
				SelectedTextColor = Color.Black,
				SelectedBorderColor = Color.Black,
				SelectedFrameBackgroundColor = Device.OnPlatform(Color.Black, Color.Black, Color.Black),
				SelectedIndex = 3,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.Center,
				Padding = new Thickness(5),
				Font = Device.OnPlatform(
					Font.OfSize("HelveticaNeue-Light", NamedSize.Medium),
					Font.OfSize("Roboto Light", NamedSize.Medium),
					Font.OfSize("Segoe WP Light", NamedSize.Medium)),
				Items = buttonGroupMovieStartTimesItems,
			};

			var labelMovieStartTimes = new Label
			{
				Text = "Service Time",
				TextColor = Device.OnPlatform(Color.White, Color.White, Color.White),
			};

            var btnConfirm = new Button()
            {
                Text = "Confirm",
                BackgroundColor = Color.Gray
            };
		    btnConfirm.Clicked += (s, e) =>
		    {
                DisplayAlert("To DO", "go to my orders page.", "OK");
            };

			var stack = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					labelMovieStartTimes,
					buttonGroupMovieStartTimes,
                    btnConfirm
				},
			};

			Title = "Services";
			BackgroundColor = Color.Black;
			Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
			Content = stack;
		}
	}
}

