using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FuckDM
{
    public partial class Feed : ContentPage
    {
        public Feed()
        {
            InitializeComponent();
        }
        private async void Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutThis());
        }
    }
}
