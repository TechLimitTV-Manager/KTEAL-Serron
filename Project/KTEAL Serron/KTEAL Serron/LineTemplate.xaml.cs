using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace KTEAL_Serron
{
    public sealed partial class LineTemplate : Page
    {
        Line CalledLine;

        public LineTemplate()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            CalledLine = e.Parameter as Line;
        }

        private void LineTemplate_Page_Loading(FrameworkElement sender, object args)
        {
            DaySelector.Items.Add("ΚΑΘΗΜΕΡΙΝΗ");
            DaySelector.Items.Add("ΣΑΒΒΑΤΟ");
            DaySelector.Items.Add("ΚΥΡΙΑΚΗ");

            LineName.Text = CalledLine.GetNumber().ToString() + " - " + CalledLine.GetTitle();

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;
            if (AutoSetDay == 0)
            {
                UpdateLists(CalledLine.GetSundayN(), CalledLine.GetSundayR());
                DaySelector.SelectedIndex = DaySelector.Items.IndexOf("ΚΥΡΙΑΚΗ");

            }
            else if (AutoSetDay == 6)
            {
                UpdateLists(CalledLine.GetSaturdayN(), CalledLine.GetSaturdayR());
                DaySelector.SelectedIndex = DaySelector.Items.IndexOf("ΣΑΒΒΑΤΟ");

            }
            else
            {
                UpdateLists(CalledLine.GetDailyN(), CalledLine.GetDailyR());
                DaySelector.SelectedIndex = DaySelector.Items.IndexOf("ΚΑΘΗΜΕΡΙΝΗ");
            }
        }

        private void DaySelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(DaySelector.SelectedItem.ToString() == "ΚΑΘΗΜΕΡΙΝΗ")
            {
                UpdateLists(CalledLine.GetDailyN(), CalledLine.GetDailyR());
            }
            else if (DaySelector.SelectedItem.ToString() == "ΣΑΒΒΑΤΟ")
            {
                UpdateLists(CalledLine.GetSaturdayN(), CalledLine.GetSaturdayR());
            }
            else
            {
                UpdateLists(CalledLine.GetSundayN(), CalledLine.GetSundayR());
            }
            
        }

        private void UpdateLists(String[] InfoN, String[] InfoR)
        {
            NormalLine.Items.Clear();   
            for(int Counter = 0; Counter < InfoN.Length; Counter++)
            {
                NormalLine.Items.Add(InfoN[Counter]);
            }

            ReturnLine.Items.Clear();
            for (int Counter = 0; Counter < InfoR.Length; Counter++)
            {
                ReturnLine.Items.Add(InfoR[Counter]);
            }
        }
    }
}
