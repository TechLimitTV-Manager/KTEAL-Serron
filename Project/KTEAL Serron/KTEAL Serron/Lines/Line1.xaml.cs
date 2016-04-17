using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class Line1 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line1()
        {
            this.InitializeComponent();
        }

        private void Line1_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line1_Daily_Button.IsEnabled = false;
                Line1_Saturday_Button.IsEnabled = true;
                Line1_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line1_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line1_Daily_Button.IsEnabled = true;
                Line1_Saturday_Button.IsEnabled = false;
                Line1_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line1_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line1_Daily_Button.IsEnabled = true;
                Line1_Saturday_Button.IsEnabled = true;
                Line1_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line1_Page_Loading(FrameworkElement sender, object args)
        {
            Line1_Title.Text = "1 - ΛΕΥΚΩΝΑΣ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
               fillList(Sunday);
               CurrentSelection = "Κυριακή";
               Line1_Daily_Button.IsEnabled = true;
               Line1_Saturday_Button.IsEnabled = true;
               Line1_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                fillList(Saturday);
                CurrentSelection = "Σάββατο";
                Line1_Daily_Button.IsEnabled = true;
                Line1_Saturday_Button.IsEnabled = false;
                Line1_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line1_Daily_Button.IsEnabled = false;
                Line1_Saturday_Button.IsEnabled = true;
                Line1_Sunday_Button.IsEnabled = true;

            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
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
                "20:00",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "7:15",
                "7:45",
                "8:45",
                "9:45",
                "10:45",
                "11:45",
                "12:45",
                "13:45",
                "14:25",
             /* "15:15 (ΜΗΤΡΟΥΣΙ)",
                "16:00 (ΜΗΤΡΟΥΣΙ)",
                "18:00 (ΜΗΤΡΟΥΣΙ)",
                "20:00 (ΜΗΤΡΟΥΣΙ)",
                "21:35 (ΜΗΤΡΟΥΣΙ)", */
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣIΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "ΜΗ ΔΙΑΘΕΣIΜΟ",
            /*  "9:05 (ΜΗΤΡΟΥΣΙ)",
                "11:05 (ΜΗΤΡΟΥΣΙ)",
                "14:05 (ΜΗΤΡΟΥΣΙ)",
                "18:15 (ΜΗΤΡΟΥΣΙ)",
                "20:00 (ΜΗΤΡΟΥΣΙ)",
                "21:35 (ΜΗΤΡΟΥΣΙ)", */
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣIΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line1_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line1_List.Items.Add(Times[Counter]);
            }
        }

    }
}
