using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KTEAL_Serron
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String[] MenuItems;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Home_Page_Loading(FrameworkElement sender, object args)
        {
            MenuItems = new String[]
            {
                "Δρομολόγια",
                "Ρυθμίσεις",
                "Σχετικά με"
            };

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
                        ShowMsg("Μη διαθέσιμο . . .");
                        break;
                    }
                case "Ρυθμίσεις":
                    {
                        ShowMsg("Μη διαθέσιμο . . .");
                        break;
                    }
                case "Σχετικά με":
                    {
                        Frame.Navigate(typeof(AboutPage));
                        break;
                    }
            }
        }

        private async void ShowMsg(String Msg)
        {
            var ShowMsg = new Windows.UI.Popups.MessageDialog(Msg);
            await ShowMsg.ShowAsync();
        }
    }
}
