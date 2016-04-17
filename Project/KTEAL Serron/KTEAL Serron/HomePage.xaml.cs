using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron
{
    public sealed partial class MainPage : Page
    {
        private String[] MenuItems;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Home_Page_Loading(FrameworkElement sender, object args)
        {
            GenerateItems();
            AddItems();
        }

        private void GenerateItems()
        {
            MenuItems = new String[]
            {
                "Δρομολόγια",
                "Σχετικά με",
                "Έξοδος",
            };
        }

        private void AddItems()
        {
            for (int Counter = 0; Counter < MenuItems.Length; Counter++)
            {
                Home_Menu.Items.Add(MenuItems[Counter]);
            }
        }

        private void Home_Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Home_Menu.SelectedItem.ToString())
            {
                case "Δρομολόγια":
                    {
                        Frame.Navigate(typeof(SchedulesPage));
                        break;
                    }
                case "Σχετικά με":
                    {
                        Frame.Navigate(typeof(AboutPage));
                        break;
                    }
                case "Έξοδος":
                    {
                        Application.Current.Exit();
                        break;
                    }
            }
        }
    }
}
