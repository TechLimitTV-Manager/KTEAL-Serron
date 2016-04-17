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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace KTEAL_Serron.Lines
{
    public sealed partial class LineControl : UserControl
    {
        public LineControl()
        {
            this.InitializeComponent();
        }
        private LineTimetable lineInfo;
        private Day selectedDay;
        public void Initialize(LineTimetable TimeTable)
        {
            daysComboBox.SelectedIndex = -1;
            daysComboBox.Items.Clear();
            lineInfo = TimeTable;
            lineTextBlock.Text = TimeTable.Name;
            foreach (var Day in TimeTable.Days)
            {
                daysComboBox.Items.Add(Day.Name);
            }

            int AutoSetDay = (int)System.DateTime.Now.DayOfWeek;
            if (AutoSetDay == 0)
            {
                daysComboBox.SelectedIndex = daysComboBox.Items.IndexOf("ΚΥΡΙΑΚΗ");

            }
            else if (AutoSetDay == 6)
            {
                daysComboBox.SelectedIndex = daysComboBox.Items.IndexOf("ΣΑΒΒΑΤΟ");

            }
            else
            {
                daysComboBox.SelectedIndex = daysComboBox.Items.IndexOf("ΚΑΘΗΜΕΡΙΝΗ");
            }

        }

        private void daysComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (daysComboBox.SelectedIndex > -1)
            {
                foreach (var Day in lineInfo.Days)
                {
                    if (daysComboBox.SelectedItem.ToString().Equals(Day.Name))
                    {
                        selectedDay = Day;
                        updateFields();
                    }
                }
            }
        }
        private void updateFields()
        {
            goingListView.Items.Clear();
            returningListView.Items.Clear();
            foreach (var hour in selectedDay.GoingHours)
            {
                goingListView.Items.Add(hour);
            }
            foreach (var hour in selectedDay.ReturningHours)
            {
                returningListView.Items.Add(hour);
            }
        }
    }
}
