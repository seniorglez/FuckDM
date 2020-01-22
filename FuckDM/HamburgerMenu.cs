using System;

using Xamarin.Forms;

namespace FuckDM
{
    public class HamburgerMenu : ContentPage
    {
        public HamburgerMenu()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

