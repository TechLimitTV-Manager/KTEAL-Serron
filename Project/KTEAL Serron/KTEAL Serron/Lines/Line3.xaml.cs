﻿using System;
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
            }
        }

        private void Line3_Saturday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Σάββατο";
            if (CurrentSelection != Temp)
            {
                fillList(Saturday);
                CurrentSelection = Temp;
            }
        }

        private void Line3_Sunday_Button_Click(object sender, RoutedEventArgs e)
        {
            string Temp = "Κυριακή";
            if (CurrentSelection != Temp)
            {
                fillList(Sunday);
                CurrentSelection = Temp;
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
                "7:00",
                "7:30",
                "8:00",
                "8:30",
                "9:00",
                "9:30",
                "10:00",
                "10:30",
                "11:00",
                "11:30",
                "12:00",
                "12:30",
                "13:00",
                "13:30",
                "14:00",
                "14:30",
                "15:00",
                "15:30",
                "16:00",
                "16:30",
                "17:00",
                "17:30",
                "18:00",
                "18:30",
                "18:00",
                "19:30",
                "20:00",
                "20:30",
                "21:00",
                "21:30"
            };

            Saturday = new String[]
            {
                "7:00",
                "8:00",
                "9:00",
                "10:00",
                "11:00",
                "12:00",
                "13:00",
                "14:00",
                "14:45",
                "15:45",
                "16:45",
                "17:45",
                "18:45",
                "19:45",
                "20:45"
            };

            Sunday = new String[]
            {
                "8:45",
                "10:45",
                "12:45",
                "14:45",
                "16:45",
                "18:45"
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