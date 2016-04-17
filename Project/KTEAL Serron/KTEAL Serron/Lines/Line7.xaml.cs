using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class Line7 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line7()
        {
            this.InitializeComponent();
        }

        private void Line7_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line7_Daily_Button.IsEnabled = false;
                Line7_Saturday_Button.IsEnabled = true;
                Line7_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line7_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line7_Daily_Button.IsEnabled = true;
                Line7_Saturday_Button.IsEnabled = false;
                Line7_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line7_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line7_Daily_Button.IsEnabled = true;
                Line7_Saturday_Button.IsEnabled = true;
                Line7_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line7_Page_Loading(FrameworkElement sender, object args)
        {
            Line7_Title.Text = "7 - ΚΩΝΣΤΑΝΤΙΝΑΤΟ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line7_Daily_Button.IsEnabled = true;
                Line7_Saturday_Button.IsEnabled = true;
                Line7_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line7_Daily_Button.IsEnabled = true;
                Line7_Saturday_Button.IsEnabled = false;
                Line7_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line7_Daily_Button.IsEnabled = false;
                Line7_Saturday_Button.IsEnabled = true;
                Line7_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "ΜΟΝΟ ΤΡΙΤΗ",
                "8:05",
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
            Line7_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line7_List.Items.Add(Times[Counter]);
            }
        }
    }
}
