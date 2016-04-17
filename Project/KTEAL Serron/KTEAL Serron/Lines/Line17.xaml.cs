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
    public sealed partial class Line17 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line17()
        {
            this.InitializeComponent();
        }

        private void Line17_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line17_Daily_Button.IsEnabled = false;
                Line17_Saturday_Button.IsEnabled = true;
                Line17_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line17_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line17_Daily_Button.IsEnabled = true;
                Line17_Saturday_Button.IsEnabled = false;
                Line17_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line17_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line17_Daily_Button.IsEnabled = true;
                Line17_Saturday_Button.IsEnabled = true;
                Line17_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line17_Page_Loading(FrameworkElement sender, object args)
        {
            Line17_Title.Text = "17 - ΝΕΟ ΣΟΥΛΙ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if(AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line17_Daily_Button.IsEnabled = true;
                Line17_Saturday_Button.IsEnabled = true;
                Line17_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
                Line17_Daily_Button.IsEnabled = true;
                Line17_Saturday_Button.IsEnabled = false;
                Line17_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line17_Daily_Button.IsEnabled = false;
                Line17_Saturday_Button.IsEnabled = true;
                Line17_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:10",
                "7:05",
                "8:10",
                "8:50",
                "9:35",
                "10:15",
                "11:10",
                "12:10",
                "13:10",
                "14:15",
                "15:05",
                "16:15",
                "17:15",
                "18:15",
                "19:30",
                "20:35",
                "21:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:10",
                "7:05",
                "8:10",
                "8:50",
                "9:35",
                "10:15",
                "11:10",
                "12:10",
                "13:10",
                "14:15",
                "15:10",
                "17:10",
                "19:10",
                "21:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "9:15",
                "11:15",
                "14:15",
                "18:15",
                "21:15",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line17_List.Items.Clear();
            for(int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line17_List.Items.Add(Times[Counter]);
            }
        }
    }
}
