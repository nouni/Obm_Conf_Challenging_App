using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Extentions;

namespace ClientSide.Web.VOEntities
{
    public class ChallengingResultVOEntity : AbstractVOEntity
    {
        #region Attributs
        string taName = "";
        DayCount monday = new DayCount() { Count = 0, Day = DayOfWeek.Monday };
        DayCount tuesday = new DayCount() { Count = 0, Day = DayOfWeek.Tuesday };
        DayCount thursday = new DayCount() { Count = 0, Day = DayOfWeek.Thursday };
        DayCount wednesday = new DayCount() { Count = 0, Day = DayOfWeek.Wednesday };
        DayCount friday = new DayCount() { Count = 0, Day = DayOfWeek.Friday };

        WeekCount first = new WeekCount() { Count = 0, Week = WeekOfMonth.FirstWeek };
        WeekCount second = new WeekCount() { Count = 0, Week = WeekOfMonth.SecondWeek };
        WeekCount third = new WeekCount() { Count = 0, Week = WeekOfMonth.ThirdWeek };
        WeekCount fourth = new WeekCount() { Count = 0, Week = WeekOfMonth.FourthWeek };
        #endregion
        #region Properties
        public string TaName
        {
            get { return taName; }
            set { taName = value; }
        }
        public DayCount Monday
        {
            get { return monday; }
            set { monday = value; }
        }
        public DayCount Tuesday
        {
            get { return tuesday; }
            set { tuesday = value; }
        }
        public DayCount Thursday
        {
            get { return thursday; }
            set { thursday = value; }
        }
        public DayCount Wednesday
        {
            get { return wednesday; }
            set { wednesday = value; }
        }
        public DayCount Friday
        {
            get { return friday; }
            set { friday = value; }
        }
        public WeekCount First
        {
            get { return first; }
            set { first = value; }
        }
        public WeekCount Second
        {
            get { return second; }
            set { second = value; }
        }
        public WeekCount Third
        {
            get { return third; }
            set { third = value; }
        }
        public WeekCount Fourth
        {
            get { return fourth; }
            set { fourth = value; }
        }
        #endregion
        public void SetCurrentDay(DayOfWeek currentDay)
        {
            var x = this.GetType().GetProperties().Where(p => p.GetType().IsInstanceOfType(new DayCount()));
            if (x != null)
            {
                foreach (var item in x)
                {
                    var g = item.GetGetMethod();
                    var res = g.Invoke(this, null) as DayCount;
                    res.IsCurrent = false;
                    if (res.Day == currentDay) res.IsCurrent = true;
                }
            }
        }
        public void SetCurrentWeek(WeekOfMonth currentWeek)
        {
            First.IsCurrent = false;
            Second.IsCurrent = false;
            Third.IsCurrent = false;
            Fourth.IsCurrent = false;

            switch (currentWeek)
            {
                case WeekOfMonth.FirstWeek:
                    First.IsCurrent = true;
                    break;
                case WeekOfMonth.SecondWeek:
                    Second.IsCurrent = true;
                    break;
                case WeekOfMonth.ThirdWeek:
                    Third.IsCurrent = true;
                    break;
                case WeekOfMonth.FourthWeek:
                    Fourth.IsCurrent = true;
                    break;
                default:
                    break;
            }
        }
        public int MonthCount {
            get
            {
                return first + second + third + fourth;    
            }   
        }
    }

    public class DayCount
    {
        DayOfWeek day = DayOfWeek.Monday;

        public DayOfWeek Day
        {
            get { return day; }
            set { day = value; }
        }
        int count = 0;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        bool isCurrent = false;

        public bool IsCurrent
        {
            get { return isCurrent; }
            set { isCurrent = value; }
        }
        public static int operator +(DayCount a, DayCount b){
            return a.Count + b.Count;
        }
        public static DayCount operator +(DayCount a, int b)
        {
            return new DayCount() { Count = a.Count + b, Day = a.Day };
        }
        public static DayCount operator +(int b, DayCount a)
        {
            return new DayCount() { Count = a.Count + b, Day = a.Day };
        }
    }

    public class WeekCount
    {
        WeekOfMonth week = WeekOfMonth.FirstWeek;

        public WeekOfMonth Week
        {
            get { return week; }
            set { week = value; }
        }
        bool isCurrent = false;

        public bool IsCurrent
        {
            get { return isCurrent; }
            set { isCurrent = value; }
        }
        public static int operator +(WeekCount a, WeekCount b)
        {
            return a.Count + b.Count;
        }
        public static WeekCount operator +(WeekCount a, int b)
        {
            return new WeekCount() { Count = a.Count + b, Week = a.Week };
        }

        public static WeekCount operator +(int b, WeekCount a)
        {
            return new WeekCount() { Count = a.Count + b, Week = a.Week };
        }

        int count = 0;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}