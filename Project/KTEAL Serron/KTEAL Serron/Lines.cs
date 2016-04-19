using System;
using System.Collections.Generic;



namespace KTEAL_Serron
{
    public class LineTimetable
    {
        public String Name => _Name;
        private string _Name;

        public int Number => _Number;
        private int _Number;

        public string Note => _Note;
        private string _Note;

        public List<Day> Days;

        public LineTimetable(String name, int number, string note)
        {
            Days = new List<Day>();
            _Name = name;
            _Number = number;
            _Note = note;
        }

        public void addDay(String Name, String[][] Hours)
        {
            var day = new Day(Name,Hours);
            Days.Add(day);
        }
    }

    public class Day
    {
        public String Name { get; private set; }
        public List<String> GoingHours { get; private set; }
        public List<String> ReturningHours { get; private set; }

        public Day(String name, String[][] hours)
        {
            GoingHours = new List<String>();
            ReturningHours = new List<String>();
            Name = name;

            foreach (var hour in hours[0])
            {
                GoingHours.Add(hour);
            }

            foreach (var hour in hours[1])
            {
                ReturningHours.Add(hour);
            }
        }
    }
}
