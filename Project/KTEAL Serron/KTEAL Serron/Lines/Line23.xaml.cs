using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class Line23 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line23()
        {
            this.InitializeComponent();
        }

        private void Line23_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line23_Daily_Button.IsEnabled = false;
                Line23_Saturday_Button.IsEnabled = true;
                Line23_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line23_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line23_Daily_Button.IsEnabled = true;
                Line23_Saturday_Button.IsEnabled = false;
                Line23_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line23_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line23_Daily_Button.IsEnabled = true;
                Line23_Saturday_Button.IsEnabled = true;
                Line23_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line23_Page_Loading(FrameworkElement sender, object args)
        {
            Line23_Title.Text = "23 - ΒΙΟΜΗΧΑΝΙΚΗ ΠΕΡΙΟΧΗ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line23_Daily_Button.IsEnabled = true;
                Line23_Saturday_Button.IsEnabled = true;
                Line23_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line23_Daily_Button.IsEnabled = true;
                Line23_Saturday_Button.IsEnabled = false;
                Line23_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line23_Daily_Button.IsEnabled = false;
                Line23_Saturday_Button.IsEnabled = true;
                Line23_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                // "7:05 (Μέσω του 2 - ΜΗΤΡΟΥΣΙ)",
                "15:40",
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
            Line23_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line23_List.Items.Add(Times[Counter]);
            }
        }
    }
}
