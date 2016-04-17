using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class Line9 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line9()
        {
            this.InitializeComponent();
        }

        private void Line9_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line9_Daily_Button.IsEnabled = false;
                Line9_Saturday_Button.IsEnabled = true;
                Line9_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line9_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line9_Daily_Button.IsEnabled = true;
                Line9_Saturday_Button.IsEnabled = false;
                Line9_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line9_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line9_Daily_Button.IsEnabled = true;
                Line9_Saturday_Button.IsEnabled = true;
                Line9_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line9_Page_Loading(FrameworkElement sender, object args)
        {
            Line9_Title.Text = "9 - ΒΑΛΤΟΤΟΠΙ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line9_Daily_Button.IsEnabled = true;
                Line9_Saturday_Button.IsEnabled = true;
                Line9_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line9_Daily_Button.IsEnabled = true;
                Line9_Saturday_Button.IsEnabled = false;
                Line9_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line9_Daily_Button.IsEnabled = false;
                Line9_Saturday_Button.IsEnabled = true;
                Line9_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:00",
                "7:00",
                "8:00",
                "9:10",
                "10:15",
                "11:30",
                "12:45",
                "14:15",
                "15:30",
                "17:00",
                "18:30",
                "20:00",
                "21:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "7:00",
                "8:00",
                "9:10",
                "10:15",
                "11:30",
                "12:45",
                "14:15",
                "15:15",
                "18:00",
                "21:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "8:00",
                "12:00",
                "15:15",
                "20:35",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line9_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line9_List.Items.Add(Times[Counter]);
            }
        }
    }
}
