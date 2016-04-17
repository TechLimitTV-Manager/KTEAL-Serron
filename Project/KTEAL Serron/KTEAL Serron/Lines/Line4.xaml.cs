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
    public sealed partial class Line4 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line4()
        {
            this.InitializeComponent();
        }

        private void Line4_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line4_Daily_Button.IsEnabled = false;
                Line4_Saturday_Button.IsEnabled = true;
                Line4_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line4_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line4_Daily_Button.IsEnabled = true;
                Line4_Saturday_Button.IsEnabled = false;
                Line4_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line4_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line4_Daily_Button.IsEnabled = true;
                Line4_Saturday_Button.IsEnabled = true;
                Line4_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line4_Page_Loading(FrameworkElement sender, object args)
        {
            Line4_Title.Text = "4 - ΚΑΛΥΒΙΑ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line4_Daily_Button.IsEnabled = true;
                Line4_Saturday_Button.IsEnabled = true;
                Line4_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line4_Daily_Button.IsEnabled = true;
                Line4_Saturday_Button.IsEnabled = false;
                Line4_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line4_Daily_Button.IsEnabled = false;
                Line4_Saturday_Button.IsEnabled = true;
                Line4_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:35",
                "7:00",
                "7:30",
                "8:00",
                "8:30",
                "9:00",
                "9:30",
                "10:00",
                "10:30",
                "11:00",
                "11:30",
                "12:00",
                "12:30",
                "13:00",
                "13:30",
                "14:00",
                "14:30",
                "15:00",
                "15:30",
                "16:00",
                "16:30",
                "17:00",
                "17:30",
                "18:00",
                "18:30",
                "18:00",
                "19:30",
                "20:00",
                "20:30",
                "21:00",
                "21:30",
                "22:00",
                "22:30",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:35",
                "7:00",
                "7:30",
                "8:00",
                "8:30",
                "9:00",
                "9:30",
                "10:00",
                "10:30",
                "11:00",
                "11:30",
                "12:00",
                "12:30",
                "13:00",
                "13:30",
                "14:00",
                "14:30",
                "14:45",
                "15:15",
                "16:15",
                "17:15",
                "18:15",
                "19:15",
                "20:15",
                "21:15",
                "22:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:15",
                "7:15",
                "8:15",
                "10:15",
                "12:15",
                "13:15",
                "14:15",
                "16:15",
                "17:15",
                "18:15",
                "20:15",
                "22:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line4_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line4_List.Items.Add(Times[Counter]);
            }
        }
    }
}
