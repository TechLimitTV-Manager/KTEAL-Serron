using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTEAL_Serron
{
    class Line
    {
        protected int Number;
        protected string Title;
        protected string[] DailyN, SaturdayN, SundayN, DailyR, SaturdayR, SundayR;

        public Line(int SetNumber, string SetTitle, string[] SetDailyN, string[] SetSaturdayN, string[] SetSundayN, String[] SetDailyR, String[] SetSaturdayR, String[] SetSundayR)
        {
            this.Number = SetNumber;
            this.Title = SetTitle;

            this.DailyN = SetDailyN;
            this.SaturdayN = SetSaturdayN;
            this.SundayN = SetSundayN;

            this.DailyR = SetDailyR;
            this.SaturdayR = SetSaturdayR;
            this.SundayR = SetSundayR;
        }

        public int GetNumber() { return Number; }
        public string GetTitle() { return Title; }

        public string[] GetDailyN() { return DailyN; }
        public string[] GetSaturdayN() { return SaturdayN; }
        public string[] GetSundayN() { return SundayN; }

        public string[] GetDailyR() { return DailyR; }
        public string[] GetSaturdayR() { return SaturdayR; }
        public string[] GetSundayR() { return SundayR; }

    }
}
