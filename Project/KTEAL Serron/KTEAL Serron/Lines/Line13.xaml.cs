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
    public sealed partial class Line13 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line13()
        {
            this.InitializeComponent();
        }

        private void Line13_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line13_Daily_Button.IsEnabled = false;
                Line13_Saturday_Button.IsEnabled = true;
                Line13_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line13_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line13_Daily_Button.IsEnabled = true;
                Line13_Saturday_Button.IsEnabled = false;
                Line13_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line13_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line13_Daily_Button.IsEnabled = true;
                Line13_Saturday_Button.IsEnabled = true;
                Line13_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line13_Page_Loading(FrameworkElement sender, object args)
        {
            Line13_Title.Text = "13 - ΛΑΪΚΗ ΑΓΟΡΑ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line13_Daily_Button.IsEnabled = true;
                Line13_Saturday_Button.IsEnabled = true;
                Line13_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line13_Daily_Button.IsEnabled = true;
                Line13_Saturday_Button.IsEnabled = false;
                Line13_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line13_Daily_Button.IsEnabled = false;
                Line13_Saturday_Button.IsEnabled = true;
                Line13_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "ΜΟΝΟ ΤΡΙΤΗ",
                "7:15",
                "7:25",
                "7:35",
                "7:45",
                "7:55",
                "8:05",
                "8:15",
                "8:25",
                "8:35",
                "8:45",
                "8:55",
                "9:05",
                "9:15",
                "9:25",
                "9:35",
                "9:45",
                "9:55",
                "10:05",
                "10:15",
                "10:25",
                "10:35",
                "10:45",
                "10:55",
                "11:05",
                "11:15",
                "11:25",
                "11:35",
                "11:45",
                "11:55",
                "12:05",
                "12:15",
                "12:25",
                "12:35",
                "12:45",
                "12:55",
                "13:05",
                "13:15",
                "13:25",
                "13:35",
                "13:45",
                "13:55",
                "14:05",
                "14:15",
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
            Line13_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line13_List.Items.Add(Times[Counter]);
            }
        }
    }
}
