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

namespace KTEAL_Serron
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SchedulesPage : Page
    {
        public SchedulesPage()
        {
            this.InitializeComponent();
            LineTimetables = new List<LineTimetable>();

        }
        private List<LineTimetable> LineTimetables;
        private void Schedules_Page_Loading(FrameworkElement sender, object args)
        {
            // --------------------------------------------------------------------- Line Begin
            var Line = new LineTimetable("ΛΕΥΚΩΝΑΣ", 1);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
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
                        "20:00"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
                        "7:15",
                        "7:45",
                        "8:45",
                        "9:45",
                        "10:45",
                        "11:45",
                        "12:45",
                        "13:45",
                        "14:25",
                        "15:15 (ΜΗΤΡΟΥΣΙ)",
                        "16:00 (ΜΗΤΡΟΥΣΙ)",
                        "18:00 (ΜΗΤΡΟΥΣΙ)",
                        "20:00 (ΜΗΤΡΟΥΣΙ)",
                        "21:35 (ΜΗΤΡΟΥΣΙ)"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "9:05 (ΜΗΤΡΟΥΣΙ)",
                        "11:05 (ΜΗΤΡΟΥΣΙ)",
                        "14:05 (ΜΗΤΡΟΥΣΙ)",
                        "18:15 (ΜΗΤΡΟΥΣΙ)",
                        "20:00 (ΜΗΤΡΟΥΣΙ)",
                        "21:35 (ΜΗΤΡΟΥΣΙ)",
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End

            // --------------------------------------------------------------------- Line Begin
            Line = new LineTimetable("ΜΗΤΡΟΥΣΙ", 2);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
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
                        "21:35"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
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
                        "21:35"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "9:05",
                        "11:05",
                        "14:05",
                        "18:15",
                        "20:00",
                        "21:35"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End

            // --------------------------------------------------------------------- Line Begin
            Line = new LineTimetable("ΟΜΟΝΟΙΑ", 3);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
                        "7:15",
                        "7:45",
                        "8:15",
                        "8:45",
                        "9:15",
                        "9:45",
                        "10:15",
                        "10:45",
                        "11:15",
                        "11:45",
                        "12:15",
                        "12:45",
                        "13:15",
                        "13:45",
                        "14:15",
                        "14:45"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End

            // --------------------------------------------------------------------- Line Begin
            Line = new LineTimetable("ΚΑΛΥΒΙΑ", 4);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
                        "6:35",
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
                        "21:30",
                        "22:00",
                        "22:30"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
                        "6:35",
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
                        "14:45",
                        "15:15",
                        "16:15",
                        "17:15",
                        "18:15",
                        "19:15",
                        "20:15",
                        "21:15",
                        "22:15"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "6:15",
                        "7:15",
                        "8:15",
                        "10:15",
                        "12:15",
                        "13:15",
                        "14:15",
                        "16:15",
                        "17:15",
                        "18:15",
                        "20:15",
                        "22:15"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End

            // --------------------------------------------------------------------- Line Begin
            Line = new LineTimetable("NIKAIA", 5);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
                        "6:35",
                        "7:15",
                        "7:45",
                        "8:15",
                        "8:45",
                        "9:15",
                        "9:45",
                        "10:15",
                        "10:45",
                        "11:15",
                        "11:45",
                        "12:15",
                        "12:45",
                        "13:15",
                        "13:45",
                        "14:15",
                        "14:45",
                        "15:15",
                        "16:15",
                        "17:15",
                        "17:45",
                        "18:15",
                        "18:45",
                        "19:15",
                        "19:45",
                        "20:15",
                        "20:45",
                        "21:15"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
                        "6:35",
                        "7:15",
                        "7:45",
                        "8:15",
                        "8:45",
                        "9:15",
                        "9:45",
                        "10:15",
                        "10:45",
                        "11:15",
                        "11:45",
                        "12:15",
                        "12:45",
                        "13:15",
                        "13:45",
                        "14:15",
                        "14:45",
                        "15:15",
                        "15:45",
                        "16:15",
                        "16:45",
                        "17:15",
                        "18:15",
                        "19:15",
                        "20:15",
                        "21:15"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "7:45",
                        "9:45",
                        "11:45",
                        "13:45",
                        "15:45",
                        "17:45",
                        "19:45"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End

            // --------------------------------------------------------------------- Line Begin
            Line = new LineTimetable("ΚΩΝΣΤΑΝΤΙΝΑΤΟ", 7);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
                        "ΜΟΝΟ ΤΡΙΤΗ",
                        "8:05"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End

            // --------------------------------------------------------------------- Line Begin
            Line = new LineTimetable("ΒΑΛΤΟΤΟΠΙ", 9);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
                       "6:00",
                       "7:00",
                       "8:00",
                       "9:10",
                       "10:15",
                       "11:30",
                       "12:45",
                       "14:15",
                       "15:30",
                       "17:00",
                       "18:30",
                       "20:00",
                       "21:15"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
                        "7:00",
                        "8:00",
                        "9:10",
                        "10:15",
                        "11:30",
                        "12:45",
                        "14:15",
                        "15:15",
                        "18:00",
                        "21:15"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "8:00",
                        "12:00",
                        "15:15",
                        "20:35"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End

            // --------------------------------------------------------------------- Line Begin
            Line = new LineTimetable("TEI από ΜΕΡΑΡΧΙΑΣ", 10);
            Line.addDay(
                "ΚΑΘΗΜΕΡΙΝΕΣ",
                new String[][]
                    {
                    new String[] {
                       "7:25",
                       "7:45",
                       "8:00",
                       "8:15",
                       "8:45",
                       "9:15",
                       "9:45",
                       "10:15",
                       "10:45",
                       "11:15",
                       "11:45",
                       "12:15",
                       "12:45",
                       "13:15",
                       "13:45",
                       "14:15",
                       "14:45",
                       "15:15",
                       "15:45",
                        "16:15",
                        "16:45",
                        "17:15",
                        "17:45",
                        "18:15",
                        "18:45",
                        "19:15",
                        "19:45",
                        "20:15",
                        "20:45",
                        "21:15"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 }
            );
            Line.addDay(
                "ΣΑΒΒΑΤΟ",
                new String[][]
                    {
                    new String[] {
                         "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            Line.addDay(
                "ΚΥΡΙΑΚΗ",
                new String[][]
                    {
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    },
                    new String[] {
                        "ΜΗ ΔΙΑΘΕΣΙΜΟ"
                    }
                 });
            LineTimetables.Add(Line);
            // --------------------------------------------------------------------- Line End


            foreach (var line in LineTimetables)
            {
                Schedules_Menu.Items.Add(line.Number + " - " + line.Name);
            }
        }

        private void Schedules_Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Schedules_Menu.SelectedIndex > -1)
            {
                String Selected = Schedules_Menu.SelectedItem.ToString();
                foreach (var Line in LineTimetables)
                {
                    if (Selected.Equals(Line.Number + " - " + Line.Name))
                    {
                        lineControl.Initialize(Line);
                        showLine();
                    }
                }
            }
        }
        public Boolean isListVisible { get { return Schedules_Menu.Visibility == Visibility.Visible; } }
        public void showList()
        {
            Schedules_Menu.Visibility = Visibility.Visible;
            Schedules_Msg.Visibility = Visibility.Visible;
            lineControl.Visibility = Visibility.Collapsed;
            Schedules_Menu.SelectedIndex = -1;
        }
        public void showLine()
        {
            
            Schedules_Menu.Visibility = Visibility.Collapsed;
            Schedules_Msg.Visibility = Visibility.Collapsed;
            lineControl.Visibility = Visibility.Visible;
        }

    }
}
