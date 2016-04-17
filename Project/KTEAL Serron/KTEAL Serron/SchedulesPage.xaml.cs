using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron
{
    public sealed partial class SchedulesPage : Page
    {
        private String[] MenuItems;
        Line SelectedLine;
        int LineNumber;
        String LineTitle;
        String[] LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR;

        Line Line1, Line2, Line3, Line4, Line5, Line7, Line9, Line10, Line13, Line14, Line15, Line16, Line17, Line18, Line20, Line23;

        public SchedulesPage()
        {
            this.InitializeComponent();
        }

        private void Schedules_Page_Loading(FrameworkElement sender, object args)
        {
            GenerateItems();
            AddItems();
            MakeLines();
        }

        private void MakeLines()
        {
            MakeLine1();
            MakeLine2();
            MakeLine3();
            MakeLine4();
            MakeLine5();
            MakeLine7();
            MakeLine9();
            MakeLine10();
            MakeLine13();
            MakeLine14();
            MakeLine15();
            MakeLine16();
            MakeLine17();
            MakeLine18();
            MakeLine20();
            MakeLine23();
        }

        private void MakeLine1()
        {
            // Γραμμή No 1
            LineNumber = 1; // Νουμερο γραμμής
            LineTitle = "ΛΕΥΚΩΝΑΣ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
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
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "9:05 (ΜΗΤΡΟΥΣΙ)",
                "11:05 (ΜΗΤΡΟΥΣΙ)",
                "14:05 (ΜΗΤΡΟΥΣΙ)",
                "18:15 (ΜΗΤΡΟΥΣΙ)",
                "20:00 (ΜΗΤΡΟΥΣΙ)",
                "21:35 (ΜΗΤΡΟΥΣΙ)",
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line1 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //
        }

        private void MakeLine2()
        {
            // Γραμμή No 2
            LineNumber = 2; // Νουμερο γραμμής
            LineTitle = "ΜΗΤΡΟΥΣΙ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
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
                "21:35"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
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
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                 "9:05",
                "11:05",
                "14:05",
                "18:15",
                "20:00",
                "21:35"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line2 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //
        }

        private void MakeLine3()
        {
            // Γραμμή No 3
            LineNumber = 3; // Νουμερο γραμμής
            LineTitle = "ΟΜΟΝΟΙΑ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line3 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //
        }

        private void MakeLine4()
        {
            // Γραμμή No 4
            LineNumber = 4; // Νουμερο γραμμής
            LineTitle = "ΚΑΛΥΒΙΑ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
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
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
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
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line4 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine5()
        {
            // Γραμμή No 5
            LineNumber = 5; // Νουμερο γραμμής
            LineTitle = "NIKAIA - ΚΤΕΛ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
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
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "7:45",
                "9:45",
                "11:45",
                "13:45",
                "15:45",
                "17:45",
                "19:45"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line5 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine7()
        {
            // Γραμμή No 7
            LineNumber = 7; // Νουμερο γραμμής
            LineTitle = "ΚΩΝΣΤΑΝΤΙΝΑΤΟ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
                "ΜΟΝΟ ΤΡΙΤΗ",
                "8:05"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line7 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine9()
        {
            // Γραμμή No 9
            LineNumber = 9; // Νουμερο γραμμής
            LineTitle = "ΒΑΛΤΟΤΟΠΙ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
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
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "8:00",
                "12:00",
                "15:15",
                "20:35"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line9 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine10()
        {
            // Γραμμή No 10
            LineNumber = 10; // Νουμερο γραμμής
            LineTitle = "TEI από ΜΕΡΑΡΧΙΑΣ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line10 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine13()
        {
            // Γραμμή No 13
            LineNumber = 13; // Νουμερο γραμμής
            LineTitle = "ΛΑΪΚΗ ΑΓΟΡΑ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
                "14:15"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line13 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine14()
        {
            // Γραμμή No 14
            LineNumber = 14; // Νουμερο γραμμής
            LineTitle = "ΣΦΑΓΕΙΑ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
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

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
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

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "8:45",
                "10:45",
                "12:45",
                "14:45",
                "16:45",
                "18:45"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line14 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //
        }

        private void MakeLine15()
        {
            // Γραμμή No 15
            LineNumber = 15; // Νουμερο γραμμής
            LineTitle = "ΝΕΟΧΩΡΙ - ΜΟΝΟΒΡΥΣΗ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
                "6:10",
                "7:05",
                "8:10",
                "9:35",
                "11:05",
                "12:05",
                "13:05",
                "14:15",
                "15:30",
                "17:00",
                "18:30",
                "20:00",
                "21:15"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "7:05",
                "8:10",
                "9:35",
                "11:05",
                "12:05",
                "13:05",
                "14:15",
                "16:15",
                "17:00",
                "20:35"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "10:00",
                "15:15",
                "20:35"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line15 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine16()
        {
            // Γραμμή No 16
            LineNumber = 16; // Νουμερο γραμμής
            LineTitle = "ΚΡΙΝΟΣ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
                "8:30",
                "12:30"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line16 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine17()
        {
            // Γραμμή No 17
            LineNumber = 17; // Νουμερο γραμμής
            LineTitle = "ΝΕΟ ΣΟΥΛΙ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
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
                "21:15"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
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
                "21:15"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "9:15",
                "11:15",
                "14:15",
                "18:15",
                "21:15"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line17 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine18()
        {
            // Γραμμή No 18
            LineNumber = 18; // Νουμερο γραμμής
            LineTitle = "ΝΟΣΟΚΟΜΕΙΟ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
                "6:30",
                "6:45",
                "7:00",
                "7:15",
                "7:30",
                "7:45",
                "8:00",
                "8:15",
                "8:30",
                "8:45",
                "9:00",
                "9:15",
                "9:30",
                "9:45",
                "10:00",
                "10:15",
                "10:30",
                "10:45",
                "11:00",
                "11:15",
                "11:30",
                "11:45",
                "12:00",
                "12:15",
                "12:30",
                "12:45",
                "13:00",
                "13:15",
                "13:30",
                "13:45",
                "14:00",
                "14:15",
                "14:30",
                "14:45",
                "15:00",
                "15:30",
                "16:00",
                "16:30",
                "17:00",
                "17:30",
                "18:00",
                "18:30",
                "19:00",
                "19:30",
                "20:00",
                "20:30",
                "21:00",
                "21:30",
                "22:00",
                "22:40"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "6:30",
                "6:45",
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
                "15:45",
                "16:45",
                "17:45",
                "18:45",
                "19:45",
                "20:45",
                "21:45",
                "22:40"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "6:45",
                "8:45",
                "10:45",
                "12:45",
                "13:45",
                "14:45",
                "16:45",
                "17:45",
                "18:45",
                "20:45",
                "22:40"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line18 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine20()
        {
            // Γραμμή No 20
            LineNumber = 20; // Νουμερο γραμμής
            LineTitle = "ΑΓΙΟΣ ΙΩΑΝΝΗΣ - ΟΙΝΟΥΣΑ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
                "6:30",
                "7:15 (ΟΙΝΟΥΣΑ)",
                "7:45",
                "8:15",
                "8:45 (ΟΙΝΟΥΣΑ)",
                "9:15",
                "9:45",
                "10:15",
                "10:45 (ΟΙΝΟΥΣΑ)",
                "11:15",
                "11:45",
                "12:15",
                "12:45",
                "13:15 (ΟΙΝΟΥΣΑ)",
                "13:45",
                "14:15",
                "14:45 (ΟΙΝΟΥΣΑ)",
                "15:15",
                "15:45",
                "16:15",
                "16:45",
                "17:15 (ΟΙΝΟΥΣΑ)",
                "17:45",
                "18:15",
                "18:45",
                "19:15 (ΟΙΝΟΥΣΑ)",
                "19:45",
                "20:15",
                "20:45",
                "21:15 (ΟΙΝΟΥΣΑ)",
                "21:50"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "6:30",
                "7:15 (ΟΙΝΟΥΣΑ)",
                "7:45",
                "8:15",
                "8:45 (ΟΙΝΟΥΣΑ)",
                "9:15",
                "9:45",
                "10:15",
                "10:45 (ΟΙΝΟΥΣΑ)",
                "11:15",
                "11:45",
                "12:15",
                "12:45",
                "13:15 (ΟΙΝΟΥΣΑ)",
                "13:45",
                "14:15",
                "14:45 (ΟΙΝΟΥΣΑ)",
                "15:15",
                "16:15",
                "17:15 (ΟΙΝΟΥΣΑ)",
                "18:15",
                "19:15 (ΟΙΝΟΥΣΑ)",
                "20:15",
                "21:15 (ΟΙΝΟΥΣΑ)",
                "21:50"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "8:15(ΟΙΝΟΥΣΑ)",
                "9:15",
                "11:15(ΟΙΝΟΥΣΑ)",
                "13:15(ΟΙΝΟΥΣΑ)",
                "15:15",
                "17:15(ΟΙΝΟΥΣΑ)",
                "19:15",
                "21:15(ΟΙΝΟΥΣΑ)"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line20 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void MakeLine23()
        {
            // Γραμμή No 23
            LineNumber = 23; // Νουμερο γραμμής
            LineTitle = "ΒΙΟΜΗΧΑΝΙΚΗ ΠΕΡΙΟΧΗ"; // Τίτλος γραμμής
            LineDailyN = new string[] // Δρομολόγια Καθημερινής - Μετάβαση
            {
                "7:05 (Μέσω του 2)",
                "15:40"
            };

            LineSaturdayN = new string[] // Δρομολόγια Σαββάτου - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayN = new string[] // Δρομολόγια Κυριακής - Μετάβαση
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineDailyR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSaturdayR = new string[] // Δρομολόγια Σαββάτου - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };

            LineSundayR = new string[] // Δρομολόγια Καθημερινής - Επιστροφή
            {
                "ΜΗ ΔΙΑΘΕΣΙΜΟ"
            };
            Line23 = new Line(LineNumber, LineTitle, LineDailyN, LineSaturdayN, LineSundayN, LineDailyR, LineSaturdayR, LineSundayR);
            //

        }

        private void GenerateItems()
        {
            MenuItems = new String[]
            {
                "1 - ΛΕΥΚΩΝΑΣ",
                "2 - ΜΗΤΡΟΥΣΙ",
                "3 - ΟΜΟΝΟΙΑ",
                "4 - ΚΑΛΥΒΙΑ",
                "5 - NIKAIA - ΚΤΕΛ",
                "7 - ΚΩΝΣΤΑΝΤΙΝΑΤΟ",
                "9 - ΒΑΛΤΟΤΟΠΙ",
                "10 - TEI από ΜΕΡΑΡΧΙΑΣ",
                "13 - ΛΑΪΚΗ ΑΓΟΡΑ",
                "14 - ΣΦΑΓΕΙΑ - ΤΕΙ - ΚΤΕΛ",
                "15 - ΝΕΟΧΩΡΙ - ΜΟΝΟΒΡΥΣΗ",
                "16 - ΚΡΙΝΟΣ",
                "17 - ΝΕΟ ΣΟΥΛΙ",
                "18 - ΝΟΣΟΚΟΜΕΙΟ",
                "20 - ΑΓΙΟΣ ΙΩΑΝΝΗΣ - ΟΙΝΟΥΣΑ",
                "23 - ΒΙΟΜΗΧΑΝΙΚΗ ΠΕΡΙΟΧΗ"
            };
        }

        private void AddItems()
        {
            for (int Counter = 0; Counter < MenuItems.Length; Counter++)
            {
                Schedules_Menu.Items.Add(MenuItems[Counter]);
            }
        }

        private void Schedules_Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String Selected = Schedules_Menu.SelectedItem.ToString();

            if (Selected.StartsWith("1 "))
            {
                SelectedLine = Line1;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("2 "))
            {
                SelectedLine = Line2;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("3 "))
            {
                SelectedLine = Line3;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("4 "))
            {
                SelectedLine = Line4;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("5 "))
            {
                SelectedLine = Line5;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("7 "))
            {
                SelectedLine = Line7;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);;
            }
            else if (Selected.StartsWith("9 "))
            {
                SelectedLine = Line9;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("10"))
            {
                SelectedLine = Line10;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("13"))
            {
                SelectedLine = Line13;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("14"))
            {
                SelectedLine = Line14;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("15"))
            {
                SelectedLine = Line15;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("16"))
            {
                SelectedLine = Line16;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("17"))
            {
                SelectedLine = Line17;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("18"))
            {
                SelectedLine = Line18;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("20"))
            {
                SelectedLine = Line20;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }
            else if (Selected.StartsWith("23"))
            {
                SelectedLine = Line23;
                Frame.Navigate(typeof(LineTemplate), SelectedLine);
            }

        }
    }
}
