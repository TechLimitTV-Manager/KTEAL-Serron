using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class Line18 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line18()
        {
            this.InitializeComponent();
        }

        private void Line18_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line18_Daily_Button.IsEnabled = false;
                Line18_Saturday_Button.IsEnabled = true;
                Line18_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line18_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line18_Daily_Button.IsEnabled = true;
                Line18_Saturday_Button.IsEnabled = false;
                Line18_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line18_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line18_Daily_Button.IsEnabled = true;
                Line18_Saturday_Button.IsEnabled = true;
                Line18_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line18_Page_Loading(FrameworkElement sender, object args)
        {
            Line18_Title.Text = "18 - ΝΟΣΟΚΟΜΕΙΟ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line18_Daily_Button.IsEnabled = true;
                Line18_Saturday_Button.IsEnabled = true;
                Line18_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line18_Daily_Button.IsEnabled = true;
                Line18_Saturday_Button.IsEnabled = false;
                Line18_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line18_Daily_Button.IsEnabled = false;
                Line18_Saturday_Button.IsEnabled = true;
                Line18_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:30",
                "6:45",
                "7:00",
                "7:15",
                "7:30",
                "7:45",
                "8:00",
                "8:15",
                "8:30",
                "8:45",
                "9:00",
                "9:15",
                "9:30",
                "9:45",
                "10:00",
                "10:15",
                "10:30",
                "10:45",
                "11:00",
                "11:15",
                "11:30",
                "11:45",
                "12:00",
                "12:15",
                "12:30",
                "12:45",
                "13:00",
                "13:15",
                "13:30",
                "13:45",
                "14:00",
                "14:15",
                "14:30",
                "14:45",
                "15:00",
                "15:30",
                "16:00",
                "16:30",
                "17:00",
                "17:30",
                "18:00",
                "18:30",
                "19:00",
                "19:30",
                "20:00",
                "20:30",
                "21:00",
                "21:30",
                "22:00",
                "22:40",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:30",
                "6:45",
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
                "15:45",
                "16:45",
                "17:45",
                "18:45",
                "19:45",
                "20:45",
                "21:45",
                "22:40",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:45",
                "8:45",
                "10:45",
                "12:45",
                "13:45",
                "14:45",
                "16:45",
                "17:45",
                "18:45",
                "20:45",
                "22:40",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line18_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line18_List.Items.Add(Times[Counter]);
            }
        }
    }
}
