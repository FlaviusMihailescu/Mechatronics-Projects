using FirstLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstLoginApp.Views.DetailViews.SettingsViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsScreen : ContentPage
    {
        Settings settings;
        SwitchCell switchCell1;
        SwitchCell switchCell2;
        SwitchCell switchCell3;
        //User currentUser;

        public SettingsScreen()
        {
            InitializeComponent();
            BackgroundColor = Constants.BackgroundColor;
            loadSettings();
            App.StartCheckIfInternet(lbl_NoInternet, this); 
            Title = Constants.SettingsScreenTitle;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.StartCheckIfInternet(lbl_NoInternet, this);
        }
        private void loadSettings()
        {
            settings = App.SettingsDatabase.GetSettings();
            //currentUser = App.UserDatabase.GetUser();

            TableView table;

            switchCell1 = new SwitchCell
            {
                Text = "SwitchCell 1",
                On = settings.switch1
            };
            switchCell1.OnChanged += (object sender, ToggledEventArgs e) =>
            {
                switchCell1Switched(sender, e);
            };

            switchCell2 = new SwitchCell
            {
                Text = "SwitchCell 2",
                On = settings.switch2
            };
            switchCell2.OnChanged += (object sender, ToggledEventArgs e) =>
            {
                switchCell2Switched(sender, e);
            };

            switchCell3 = new SwitchCell
            {
                Text = "SwitchCell 3",
                On = settings.switch3
            };
            switchCell3.OnChanged += (object sender, ToggledEventArgs e) =>
            {
                switchCell3Switched(sender, e);
            };




            table = new TableView
            {
                Root = new TableRoot
               {
                   new TableSection
                   {
                       switchCell1,
                       switchCell2,
                       switchCell3
                   }
               }
            };

            table.VerticalOptions = LayoutOptions.FillAndExpand;

            MainLayaout.Children.Add(table);
        }

        private void switchCell2Switched(object sender, ToggledEventArgs e)
        {
            settings.switch2 = e.Value;
        }
        private void switchCell3Switched(object sender, ToggledEventArgs e)
        {
            settings.switch2 = e.Value;
        }

        private void switchCell1Switched(object sender, ToggledEventArgs e)
        {
            settings.switch1 = e.Value;
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            var action = await DisplayAlert("Settings", "Do you want to save the settings", "Oke", "Cancel");
            if(action)
                saveSettings();
        }

        private void saveSettings()
        {
            App.SettingsDatabase.SaveSettings(settings); 
        }
    }
}