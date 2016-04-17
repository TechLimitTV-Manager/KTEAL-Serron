using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class Line3 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line3()
        {
            this.InitializeComponent();
        }

        private void Line3_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line3_Daily_Button.IsEnabled = false;
                Line3_Saturday_Button.IsEnabled = true;
                Line3_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line3_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line3_Daily_Button.IsEnabled = true;
                Line3_Saturday_Button.IsEnabled = false;
                Line3_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line3_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line3_Daily_Button.IsEnabled = true;
                Line3_Saturday_Button.IsEnabled = true;
                Line3_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line3_Page_Loading(FrameworkElement sender, object args)
        {
            Line3_Title.Text = "3 - ΟΜΟΝΟΙΑ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
                CurrentSelection = "Κυριακή";
                Line3_Daily_Button.IsEnabled = true;
                Line3_Saturday_Button.IsEnabled = true;
                Line3_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                fillList(Saturday);
                CurrentSelection = "Σάββατο";
                Line3_Daily_Button.IsEnabled = true;
                Line3_Saturday_Button.IsEnabled = false;
                Line3_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line3_Daily_Button.IsEnabled = false;
                Line3_Saturday_Button.IsEnabled = true;
                Line3_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "7:15",
                "7:45",
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
            Line3_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line3_List.Items.Add(Times[Counter]);
            }
        }
    }
}
