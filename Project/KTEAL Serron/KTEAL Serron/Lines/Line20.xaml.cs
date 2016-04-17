using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class Line20 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line20()
        {
            this.InitializeComponent();
        }

        private void Line20_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line20_Daily_Button.IsEnabled = false;
                Line20_Saturday_Button.IsEnabled = true;
                Line20_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line20_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line20_Daily_Button.IsEnabled = true;
                Line20_Saturday_Button.IsEnabled = false;
                Line20_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line20_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line20_Daily_Button.IsEnabled = true;
                Line20_Saturday_Button.IsEnabled = true;
                Line20_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line20_Page_Loading(FrameworkElement sender, object args)
        {
            Line20_Title.Text = "20 - ΑΓΙΟΣ ΙΩΑΝΝΗΣ - ΟΙΝΟΥΣΑ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line20_Daily_Button.IsEnabled = true;
                Line20_Saturday_Button.IsEnabled = true;
                Line20_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line20_Daily_Button.IsEnabled = true;
                Line20_Saturday_Button.IsEnabled = false;
                Line20_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line20_Daily_Button.IsEnabled = false;
                Line20_Saturday_Button.IsEnabled = true;
                Line20_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:30",
                "7:15 (ΟΙΝΟΥΣΑ)",
                "7:45",
                "8:15",
                "8:45 (ΟΙΝΟΥΣΑ)",
                "9:15",
                "9:45",
                "10:15",
                "10:45 (ΟΙΝΟΥΣΑ)",
                "11:15",
                "11:45",
                "12:15",
                "12:45",
                "13:15 (ΟΙΝΟΥΣΑ)",
                "13:45",
                "14:15",
                "14:45 (ΟΙΝΟΥΣΑ)",
                "15:15",
                "15:45",
                "16:15",
                "16:45",
                "17:15 (ΟΙΝΟΥΣΑ)",
                "17:45",
                "18:15",
                "18:45",
                "19:15 (ΟΙΝΟΥΣΑ)",
                "19:45",
                "20:15",
                "20:45",
                "21:15 (ΟΙΝΟΥΣΑ)",
                "21:50",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:30",
                "7:15 (ΟΙΝΟΥΣΑ)",
                "7:45",
                "8:15",
                "8:45 (ΟΙΝΟΥΣΑ)",
                "9:15",
                "9:45",
                "10:15",
                "10:45 (ΟΙΝΟΥΣΑ)",
                "11:15",
                "11:45",
                "12:15",
                "12:45",
                "13:15 (ΟΙΝΟΥΣΑ)",
                "13:45",
                "14:15",
                "14:45 (ΟΙΝΟΥΣΑ)",
                "15:15",
                "16:15",
                "17:15 (ΟΙΝΟΥΣΑ)",
                "18:15",
                "19:15 (ΟΙΝΟΥΣΑ)",
                "20:15",
                "21:15 (ΟΙΝΟΥΣΑ)",
                "21:50",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "8:15(ΟΙΝΟΥΣΑ)",
                "9:15",
                "11:15(ΟΙΝΟΥΣΑ)",
                "13:15(ΟΙΝΟΥΣΑ)",
                "15:15",
                "17:15(ΟΙΝΟΥΣΑ)",
                "19:15",
                "21:15(ΟΙΝΟΥΣΑ)",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line20_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line20_List.Items.Add(Times[Counter]);
            }
        }
    }
}
