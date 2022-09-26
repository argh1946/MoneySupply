﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Core.Helper
{
    public static class ConvertToDateTime
    {

        public static string HijriToDate(this string date)
        {
            try
            {
                var splitedDate = date.Split('/');
                HijriCalendar hijri = new HijriCalendar();
                var result = hijri.ToDateTime(int.Parse(splitedDate[0]), int.Parse(splitedDate[1]), int.Parse(splitedDate[2]), 0, 0, 0, 0);
                return string.Format("{2}/{1}/{0}", result.Year, result.Day.ToString("00"), result.Month.ToString("00"));
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string JalaliDateToDate(this string date)
        {
            try
            {
                var splitedDate = date.Split('/');
                PersianCalendar pc = new PersianCalendar();
                var result = pc.ToDateTime(int.Parse(splitedDate[0]), int.Parse(splitedDate[1]), int.Parse(splitedDate[2]), 0, 0, 0, 0);
                return string.Format("{2}/{1}/{0}", result.Year, result.Day.ToString("00"), result.Month.ToString("00"));
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string ToPersianDate(this DateTime date, string seprator = "/")
        {
            var ps = new PersianCalendar();
            return string.Format("{0}{3}{1}{3}{2}", ps.GetYear(date), ps.GetMonth(date).ToString("00"), ps.GetDayOfMonth(date).ToString("00"), seprator);
        }

        public static DateTime? ToDateTime(this string date)
        {
            try
            {
                if (date == null)
                {
                    return new DateTime();
                }
                var splited = date.Split('/');
                PersianCalendar ps = new PersianCalendar();
                return ps.ToDateTime(int.Parse(splited[0]), int.Parse(splited[1]), int.Parse(splited[2]), 0, 0, 0, 0);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
