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
    public sealed partial class Line2 : Page
    {
        String[] Daily, Saturday, Sunday;

        String CurrentSelection;

        public Line2()
        {
            this.InitializeComponent();
        }

        private void Line2_Daily_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Καθημερινή";
            if (CurrentSelection != Temp)
            {
                fillList(Daily);
                CurrentSelection = Temp;
                Line2_Daily_Button.IsEnabled = false;
                Line2_Saturday_Button.IsEnabled = true;
                Line2_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line2_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
                Line2_Daily_Button.IsEnabled = true;
                Line2_Saturday_Button.IsEnabled = false;
                Line2_Sunday_Button.IsEnabled = true;
            }
        }

        private void Line2_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
                Line2_Daily_Button.IsEnabled = true;
                Line2_Saturday_Button.IsEnabled = true;
                Line2_Sunday_Button.IsEnabled = false;
            }
        }

        private void Line2_Page_Loading(FrameworkElement sender, object args)
        {
            Line2_Title.Text = "2 - ΜΗΤΡΟΥΣΙ";
            setTimes();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;

            if (AutoSetDay == 0)
            {
                fillList(Sunday);
               CurrentSelection = "Κυριακή";
                Line2_Daily_Button.IsEnabled = true;
                Line2_Saturday_Button.IsEnabled = true;
                Line2_Sunday_Button.IsEnabled = false;
            }
            else if (AutoSetDay == 6)
            {
                fillList(Saturday);
                CurrentSelection = "Σάββατο";
                Line2_Daily_Button.IsEnabled = true;
                Line2_Saturday_Button.IsEnabled = false;
                Line2_Sunday_Button.IsEnabled = true;
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Καθημερινή";
                Line2_Daily_Button.IsEnabled = false;
                Line2_Saturday_Button.IsEnabled = true;
                Line2_Sunday_Button.IsEnabled = true;
            }
        }

        void setTimes()
        {
            Daily = new String[]
            {
               "6:05",
                "6:30",
                "7:05",
                "8:05",
                "9:05",
                "10:05",
                "11:05",
                "12:05",
                "13:05",
                "14:05",
                "15:15",
                "16:15",
                "17:00",
                "18:15",
                "19:15",
                "20:35",
                "21:35",
            };

            Saturday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "6:30",
                "7:05",
                "8:05",
                "9:05",
                "10:05",
                "11:05",
                "12:05",
                "13:05",
                "14:05",
                "15:15",
                "16:00",
                "18:00",
                "20:00",
                "21:35",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            Sunday = new String[]
            {
                "-- ΜΕΤΑΒΑΣΗ --",
                "9:05",
                "11:05",
                "14:05",
                "18:15",
                "20:00",
                "21:35",
                "-- ΕΠΙΣΤΡΟΦΗ --",
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

        }

        void fillList(String[] Times)
        {
            Line2_List.Items.Clear();
            for (int Counter = 0; Counter < Times.Length; Counter++)
            {
                Line2_List.Items.Add(Times[Counter]);
            }
        }
    }
}
