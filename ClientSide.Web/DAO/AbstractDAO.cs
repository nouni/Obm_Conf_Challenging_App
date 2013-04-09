using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Extentions;

namespace ClientSide.Web.DAO
{
    public abstract class AbstractDAO
    {
        #region GetStatistiques per days
        /// <summary>
        /// Get statistiques per days of week current week.
        /// Week days has this order : Monday, Tuesday, Thursday, wednesday, Friday, Saturday and Sunday
        /// This days are calculated by reference to current day.
        /// </summary>
        /// <param name="days"></param>
        /// <returns>List of entities (Id, TaName, Count)</returns>
        public List<Entities.StandardEntity> GetStatistiques(DayOfWeek days)
        {
            switch (days)
            {
                case DayOfWeek.Friday:
                    return GetStatistiquesForFriday();
                case DayOfWeek.Monday:
                    return GetStatistiquesForMonday();
                case DayOfWeek.Saturday:
                    return GetStatistiquesForSaturday();
                case DayOfWeek.Sunday:
                    return GetStatistiquesForSunday();
                case DayOfWeek.Thursday:
                    return GetStatistiquesForThursday();
                case DayOfWeek.Tuesday:
                    return GetStatistiquesForTuesday();
                case DayOfWeek.Wednesday:
                    return GetStatistiquesForWednesday();
                default:
                    return null;
            }
        }

        protected abstract List<Entities.StandardEntity> GetStatistiquesForWednesday();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForTuesday();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForThursday();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForSunday();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForSaturday();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForFriday();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForMonday();
        #endregion
        #region GetStatistiques per weeks
        /// <summary>
        /// Get statistiques per weeks of current month.
        /// Each month has four weeks (1, 2, 3 and 4)
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        public List<Entities.StandardEntity> GetStatistiques(WeekOfMonth week)
        {
            switch (week)
            {
                case WeekOfMonth.FirstWeek:
                    return GetStatistiquesForFirstWeek();
                case WeekOfMonth.SecondWeek:
                    return GetStatistiquesForSecondWeek();
                case WeekOfMonth.ThirdWeek:
                    return GetStatistiquesForThirdWeek();
                case WeekOfMonth.FourthWeek:
                    return GetStatistiquesForFourthWeek();
                default:
                    return null;
            }
        }

        protected abstract List<Entities.StandardEntity> GetStatistiquesForFourthWeek();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForThirdWeek();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForSecondWeek();
        protected abstract List<Entities.StandardEntity> GetStatistiquesForFirstWeek();
        #endregion
    }
}