using FirstLoginApp.Models;
using FirstLoginApp.Views.DetailViews;
using FirstLoginApp.Views.DetailViews.SettingsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstLoginApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listview; } }
        public List<MasterMenuItem> items;
        public MasterPage()
        {
            InitializeComponent();
            SetItems();
        }

        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("Home", "icon.png", Color.White, typeof(HomeScreen)));
            items.Add(new MasterMenuItem("History", "icon.png", Color.White, typeof(HistoryScreen)));
            items.Add(new MasterMenuItem("Settings", "icon.png", Color.White, typeof(SettingsScreen)));
            ListView.ItemsSource = items;
        }
    }
}