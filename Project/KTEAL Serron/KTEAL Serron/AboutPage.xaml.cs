using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KTEAL_Serron
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        String[] ContentItems;
        public AboutPage()
        {
            this.InitializeComponent();
        }

        private void About_Page_Loading(FrameworkElement sender, object args)
        {
            ContentItems = new String[]
            {
                "Εκδοση : " + "Alpha",
                "© 2016 TechLimitTV.eu",
            };

            for(int Counter = 0; Counter < ContentItems.Length; Counter++)
            {
                About_Content.Items.Add(ContentItems[Counter]);
            }
        }
    }
}
