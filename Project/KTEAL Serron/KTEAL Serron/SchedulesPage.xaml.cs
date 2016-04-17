using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron
{
    public sealed partial class SchedulesPage : Page
    {
        private String[] MenuItems;
        public SchedulesPage()
        {
            this.InitializeComponent();
        }

        private void Schedules_Page_Loading(FrameworkElement sender, object args)
        {
            GenerateItems();
            AddItems();
        }

        private void GenerateItems()
        {
            MenuItems = new String[]
            {
                "1 - ΛΕΥΚΩΝΑΣ",
                "2 - ΜΗΤΡΟΥΣΙ",
                "3 - ΟΜΟΝΟΙΑ",
                "4 - ΚΑΛΥΒΙΑ",
                "5 - NIKAIA - ΚΤΕΛ",
                "7 - ΚΩΝΣΤΑΝΤΙΝΑΤΟ",
                "9 - ΒΑΛΤΟΤΟΠΙ",
                "10 - TEI από ΜΕΡΑΡΧΙΑΣ",
                "13 - ΛΑΪΚΗ ΑΓΟΡΑ",
                "14 - ΣΦΑΓΕΙΑ - ΤΕΙ - ΚΤΕΛ",
                "15 - ΝΕΟΧΩΡΙ - ΜΟΝΟΒΡΥΣΗ",
                "16 - ΚΡΙΝΟΣ",
                "17 - ΝΕΟ ΣΟΥΛΙ",
                "18 - ΝΟΣΟΚΟΜΕΙΟ",
                "20 - ΑΓΙΟΣ ΙΩΑΝΝΗΣ - ΟΙΝΟΥΣΑ",
                "23 - ΒΙΟΜΗΧΑΝΙΚΗ ΠΕΡΙΟΧΗ"
            };
        }

        private void AddItems()
        {
            for (int Counter = 0; Counter < MenuItems.Length; Counter++)
            {
                Schedules_Menu.Items.Add(MenuItems[Counter]);
            }
        }

        private void Schedules_Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String Selected = Schedules_Menu.SelectedItem.ToString();

            if (Selected.StartsWith("1 "))
            {
                Frame.Navigate(typeof(Lines.Line1));
            }
            else if (Selected.StartsWith("2 "))
            {
                Frame.Navigate(typeof(Lines.Line2));
            }
            else if (Selected.StartsWith("3 "))
            {
                Frame.Navigate(typeof(Lines.Line3));
            }
            else if (Selected.StartsWith("4 "))
            {
                Frame.Navigate(typeof(Lines.Line4));
            }
            else if (Selected.StartsWith("5 "))
            {
                Frame.Navigate(typeof(Lines.Line5));
            }
            else if (Selected.StartsWith("7 "))
            {
                Frame.Navigate(typeof(Lines.Line7));
            }
            else if (Selected.StartsWith("9 "))
            {
                Frame.Navigate(typeof(Lines.Line9));
            }
            else if (Selected.StartsWith("10"))
            {
                Frame.Navigate(typeof(Lines.Line10));
            }
            else if (Selected.StartsWith("13"))
            {
                Frame.Navigate(typeof(Lines.Line13));
            }
            else if (Selected.StartsWith("14"))
            {
                Frame.Navigate(typeof(Lines.Line14));
            }
            else if (Selected.StartsWith("15"))
            {
                Frame.Navigate(typeof(Lines.Line15));
            }
            else if (Selected.StartsWith("16"))
            {
                Frame.Navigate(typeof(Lines.Line16));
            }
            else if (Selected.StartsWith("17"))
            {
                Frame.Navigate(typeof(Lines.Line17));
            }
            else if (Selected.StartsWith("18"))
            {
                Frame.Navigate(typeof(Lines.Line18));
            }
            else if (Selected.StartsWith("20"))
            {
                Frame.Navigate(typeof(Lines.Line20));
            }
            else if (Selected.StartsWith("23"))
            {
                Frame.Navigate(typeof(Lines.Line23));
            }

        }
    }
}
