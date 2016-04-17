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

namespace KTEAL_Serron.Lines
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Line10 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line10()
        {
            this.InitializeComponent();
        }

        private void Line10_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line10_Daily_Button.IsEnabled = false;
                Line10_Saturday_Button.IsEnabled = true;
                Line10_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line10_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line10_Daily_Button.IsEnabled = true;
                Line10_Saturday_Button.IsEnabled = false;
                Line10_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line10_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line10_Daily_Button.IsEnabled = true;
                Line10_Saturday_Button.IsEnabled = true;
                Line10_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line10_Page_Loading(FrameworkElement sender, object args)
        {
            Line10_Title.Text = "10 - TEI από ΜΕΡΑΡΧΙΑΣ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line10_Daily_Button.IsEnabled = true;
                Line10_Saturday_Button.IsEnabled = true;
                Line10_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line10_Daily_Button.IsEnabled = true;
                Line10_Saturday_Button.IsEnabled = false;
                Line10_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line10_Daily_Button.IsEnabled = false;
                Line10_Saturday_Button.IsEnabled = true;
                Line10_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "7:25",
                "7:45",
                "8:00",
                "8:15",
                "8:45",
                "9:15",
                "9:45",
                "10:15",
                "10:45",
                "11:15",
                "11:45",
                "12:15",
                "12:45",
                "13:15",
                "13:45",
                "14:15",
                "14:45",
                "15:15",
                "15:45",
                "16:15",
                "16:45",
                "17:15",
                "17:45",
                "18:15",
                "18:45",
                "19:15",
                "19:45",
                "20:15",
                "20:45",
                "21:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line10_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line10_List.Items.Add(Times[Counter]);
            }
        }
    }
}
