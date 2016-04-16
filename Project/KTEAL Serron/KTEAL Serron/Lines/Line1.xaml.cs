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
            }
        }

        private void Line1_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
            }
        }

        private void Line1_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
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
                CurrentSelection = "Καθημερινή";
            }
            else if (AutoSetDay == 6)
            {
                 fillList(Saturday);
                 CurrentSelection = "Σάββατο";
            }
            else
            {
                fillList(Daily);
                CurrentSelection = "Κυριακή";
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
                "ΜΗ ΔΙΑΘΕΣΗΜΟ"
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
