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
            LineTimetables = new List<LineTimetable>();

        }
        private List<LineTimetable> LineTimetables;
        private void Schedules_Page_Loading(FrameworkElement sender, object args)
        {
            var Line = new LineTimetable("ΛΕΥΚΏΝΑΣ", 1);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
                        "6:45",
                        "7:15",
                        "7:45",
                        "8:45",
                        "9:45",
                        "10:45",
                        "11:45",
                        "12:45",
                        "13:45",
                        "14:25",
                        "15:30",
                        "16:50",
                        "17:35",
                        "18:10",
                        "19:10",
                        "20:00"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ","asd"
                    }
                 }
            );

            LineTimetables.Add(Line);
            foreach (var line in LineTimetables)
            {
                Schedules_Menu.Items.Add(line.Number + " - " + line.Name);
            }
        }

        private void Schedules_Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Schedules_Menu.SelectedIndex > -1)
            {
                String Selected = Schedules_Menu.SelectedItem.ToString();
                foreach (var Line in LineTimetables)
                {
                    if (Selected.Equals(Line.Number + " - " + Line.Name))
                    {
                        lineControl.Initialize(Line);
                        showLine();
                    }
                }
            }
        }
        public Boolean isListVisible { get { return Schedules_Menu.Visibility == Visibility.Visible; } }
        public void showList()
        {
            Schedules_Menu.Visibility = Visibility.Visible;
            lineControl.Visibility = Visibility.Collapsed;
            Schedules_Menu.SelectedIndex = -1;

        }
        public void showLine()
        {
            Schedules_Menu.Visibility = Visibility.Collapsed;
            lineControl.Visibility = Visibility.Visible;
        }
        private async void ShowMsg(String MyMsg)
        {
            var ShowMsg = new Windows.UI.Popups.MessageDialog(MyMsg);
            await ShowMsg.ShowAsync();
        }
    }
}
