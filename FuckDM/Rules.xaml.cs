using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FuckDM
{
    public partial class Rules : ContentPage
    {
        public Rules()
        {
            InitializeComponent();
        }

        private async void Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Monster Manual":
                    //await Navigation.PushAsync();
                    break;
            }
            switch (((Button)sender).Text)
            {
                case "Player's Handbook":
                    await Navigation.PushAsync(new RulesPHB());
                    break;
            }

        }
    }
}
