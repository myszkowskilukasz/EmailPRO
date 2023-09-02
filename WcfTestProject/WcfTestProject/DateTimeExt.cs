using System;

namespace WcfTestProject
{
    public static class DateTimeExt
    {
        public static bool MyCompare(this DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1.Year == dateTime2.Year && dateTime1.DayOfYear == dateTime2.DayOfYear 
                && dateTime1.Hour == dateTime2.Hour && dateTime1.Minute == dateTime2.Minute
                && dateTime1.Second == dateTime2.Second;
        }
    }
}
