using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FuckDM
{
    public partial class RulesPHB : ContentPage
    {
        public RulesPHB()
        {
            InitializeComponent();
            OpenPDF("http://choisey.free.fr/3.5/Core/Indexed%20Player%20Handbook%20v3.5.pdf");
        }

        private void OpenPDF(String uri)
        {
                Device.OpenUri(new Uri(uri));
        }
    }
}
