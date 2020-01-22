using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FuckDM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HamburgerMenuDetail : MasterDetailPage
    {
        public HamburgerMenuDetail()
        {
            
            InitializeComponent();
            MyMenu();
        }
        public void MyMenu()
        {
            Detail = new NavigationPage(new Feed());
            List<Menu> menus = new List<Menu>
            {
                new Menu{Page=new CharacterPage(), MenuTitle="My Character", MenuDetail="Rotín", icon="character.png"},
                new Menu {Page = new NavigationPage(new Rules()), MenuTitle = "Roll Dices", MenuDetail = "gl", icon = "dices.png" },
                new Menu {Page = new NavigationPage(new Rules()), MenuTitle = "Rules", MenuDetail = "pdf", icon = "book.png" },
                new Menu {Page = new Feed(), MenuTitle = "Home", MenuDetail = ":)", icon = "book.png" }
            };
            ListMenu.ItemsSource = menus;

            
        }
        private void ItemSelectedListMenu(object sender, SelectedItemChangedEventArgs e)
        {
            Detail=((Menu)e.SelectedItem).Page;
        }
    }
}
