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
    public sealed partial class SchedulesPage : Page
    {
        private String[] MenuItems;
        public SchedulesPage()
        {
            this.InitializeComponent();
        }

        private void Schedules_Page_Loading(FrameworkElement sender, object args)
        {
            MenuItems = new String[]
            {
             // No ------------ Desc
                "1" + " - " + "ΛΕΥΚΩΝΑΣ",
                "2" + " - " + "ΜΗΤΡΟΥΣΙ",
                "3" + " - " + "ΟΜΟΝΟΙΑ",
                "4" + " - " + "ΚΑΛΥΒΙΑ",
                "5" + " - " + "NIKAIA_ΚΤΕΛ",
                "7" + " - " + "ΚΩΝΣΤΑΝΤΙΝΑΤΟ",
                "9" + " - " + "ΒΑΛΤΟΤΟΠΙ",
                "10" + " - " + "TEI από ΜΕΡΑΡΧΙΑΣ",
                "13" + " - " + "ΛΑΪΚΗ ΑΓΟΡΑ",
                "14" + " - " + "ΣΦΑΓΕΙΑ - ΤΕΙ -ΚΤΕΛ",
                "15" + " - " + "ΝΕΟΧΩΡΙ_ΜΟΝΟΒΡΥΣΗ",
                "16" + " - " + "ΚΡΙΝΟΣ",
                "17" + " - " + "ΝΕΟ ΣΟΥΛΙ",
                "18" + " - " + "ΝΟΣΟΚΟΜΕΙΟ",
                "20" + " - " + "ΑΓΙΟΣ ΙΩΑΝΝΗΣ ΟΙΝΟΥΣΑ",
                "23" + " - " + "ΒΙΟΜΗΧΑΝΙΚΗ ΠΕΡΟΧΗ"
            };

            for (int Counter = 0; Counter < MenuItems.Length; Counter++)
            {
                Schedules_Menu.Items.Add(MenuItems[Counter]);
            }

        }
    }
}
