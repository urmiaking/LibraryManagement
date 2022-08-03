using System;
using System.Globalization;

namespace LibraryManagement.Extensions
{
    public static class DateTimeExtension
    {
        public static DateTime ToGlobalDateTime(this string dateTimeString) =>
            DateTime.ParseExact(dateTimeString, "yyyy-MM-dd", new CultureInfo("fa-IR"));
    }
}