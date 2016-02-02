using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Globalization;
using System.Linq;

namespace XPrototype
{
    public partial class DetailPage : ContentPage
    {
        private const string ConfirmBtnStr = "Confirm";

        public DetailPage(object detail)
        {
            InitializeComponent();

            Title = "Services";
            BackgroundColor = Color.Black;

            var slots = DummyService.GetTimeSlots();
            foreach (var slot in slots)
            {
                var btn = new Button();
                btn.Text = slot;
                btn.BackgroundColor = Color.Gray;
                btn.TextColor = Color.White;

                btn.Clicked += (sender, args) =>
                {

                    foreach (var ctl in myStackLayout.Children)
                    {
                        var b = ctl as Button;
                        if (b != null && b.Text != ConfirmBtnStr)
                        {
                            ctl.BackgroundColor = Color.Gray;
                        }

                        btn.BackgroundColor = Color.Green;
                    }
                };
                myStackLayout.Children.Add(btn);
            }

            var btnConfirm = new Button()
            {
                Text = ConfirmBtnStr,
                BackgroundColor = Color.Green
            };
            btnConfirm.Clicked += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(SelectedRange()))
                {
                    DisplayAlert("Message", "Please selecte a service.", "OK");
                    return;
                }

                //TODO : insert order record here

                DisplayAlert("Message", "booked successfully.", "OK");
                Navigation.PushModalAsync(new MainPagewithMyOrder());
            };
            myStackLayout.Children.Add(btnConfirm);

        }

        private string SelectedRange()
        {
            foreach (var child in myStackLayout.Children)
            {
                var btn = child as Button;
                if (btn != null && btn.Text != ConfirmBtnStr && btn.BackgroundColor == Color.Green)
                {
                    return btn.Text;
                }
            }

            return null;
        }
    }
}

