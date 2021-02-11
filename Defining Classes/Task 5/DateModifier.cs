using System;

namespace DefiningClasses
{
    public static class DateModifier
    {

        public static int CalculateDifference(string dateOneStr, string dateTwoStr)
        {
            DateTime dateOne = DateTime.Parse(dateOneStr);
            DateTime dateTwo = DateTime.Parse(dateTwoStr);

            TimeSpan diff = dateOne - dateTwo;

            return Math.Abs(diff.Days);
        }
    }
}