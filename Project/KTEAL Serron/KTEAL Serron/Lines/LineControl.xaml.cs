using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron.Lines
{
    public sealed partial class LineControl : UserControl
    {
        private LineTimetable lineInfo;
        private Day selectedDay;

        public LineControl()
        {
            this.InitializeComponent();
        }

        public void Initialize(LineTimetable TimeTable)
        {
            daysComboBox.SelectedIndex = -1;
            daysComboBox.Items.Clear();
            
            lineInfo = TimeTable;
            lineTextBlock.Text = TimeTable.Number + " - " + TimeTable.Name;

            foreach (var Day in TimeTable.Days)
            {
                daysComboBox.Items.Add(Day.Name);
            }
            AutoSetDay();
            SetNote();
        }

        private void AutoSetDay()
        {
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
                daysComboBox.SelectedIndex = daysComboBox.Items.IndexOf("ΚΑΘΗΜΕΡΙΝΕΣ");
            }
        }

        private void daysComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (daysComboBox.SelectedIndex >= 0)
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
            goingListView.SelectedIndex = AutoSetTimeGoing();
            goingListView.ScrollIntoView(goingListView.SelectedItem);

            foreach (var hour in selectedDay.ReturningHours)
            {
                returningListView.Items.Add(hour);
            }
            returningListView.SelectedIndex = AutoSetTimeReturning();
            returningListView.ScrollIntoView(returningListView.SelectedItem);
        }

        private void SetNote()
        {
            if (lineInfo.Note == "")
            {
                noteTextBlock.Visibility = Visibility.Collapsed;
                noteTextBlock.Text = "";
            }
            else
            {
                noteTextBlock.Visibility = Visibility.Visible;
                noteTextBlock.Text = lineInfo.Note;
            }
        }

        private int AutoSetTimeGoing()
        {
            int IndexOfTime = 0;
            if (goingListView.Items.Contains("ΜΗ ΔΙΑΘΕΣΙΜΟ"))
            {
                IndexOfTime = 0;
            }
            else
            {
                bool IndexFound = false;
                string CurrentTime = System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString();

                TimeSpan CurrentTimeSpan = TimeSpan.Parse(CurrentTime);
                TimeSpan ListTimeSpan;

                for (int Counter = 0; Counter < goingListView.Items.Count; Counter++)
                {
                    if (IndexFound == false)
                    {
                        ListTimeSpan = TimeSpan.Parse(goingListView.Items[Counter].ToString());
                        if (CurrentTimeSpan.CompareTo(ListTimeSpan) == -1)
                        {
                            IndexOfTime = Counter;
                            IndexFound = true;
                        }
                    }
                }
            }
            return IndexOfTime;
        }

        private int AutoSetTimeReturning()
        {
            int IndexOfTime = 0;
            if (returningListView.Items.Contains("ΜΗ ΔΙΑΘΕΣΙΜΟ"))
            {
                IndexOfTime = 0;
            }
            else
            {
                bool IndexFound = false;
                string CurrentTime = System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString();

                TimeSpan CurrentTimeSpan = TimeSpan.Parse(CurrentTime);
                TimeSpan ListTimeSpan;

                for (int Counter = 0; Counter < returningListView.Items.Count; Counter++)
                {
                    if (IndexFound == false)
                    {
                        ListTimeSpan = TimeSpan.Parse(returningListView.Items[Counter].ToString());
                        if (CurrentTimeSpan.CompareTo(ListTimeSpan) == -1)
                        {
                            IndexOfTime = Counter;
                            IndexFound = true;
                        }
                    }
                }
            }
            return IndexOfTime;
        }

        private void goingListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Do Nothing
        }

        private void returningListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Do Nothing
        }

        private void goingListView_Loaded(object sender, RoutedEventArgs e)
        {
            // Do Nothing
        }

        private void returningListView_Loaded(object sender, RoutedEventArgs e)
        {
            // Do Nothing
        }
    }
}