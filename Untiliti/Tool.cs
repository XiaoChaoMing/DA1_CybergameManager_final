using System;
using System.Collections.Generic;
using System.Text;
namespace Untiliti
{
    public class Tool
    {
        public static TimeSpan QuyDoiGia (decimal money)
        {
            const decimal moneyToMinute = 5000;
            decimal minute = (money / moneyToMinute) * 60;
            decimal hours = minute / 60;
            decimal minutesRemaint = (minute % 60)*60;
            TimeSpan t = new TimeSpan(Convert.ToInt32(hours),Convert.ToInt32(minutesRemaint),0);
            return t;

        }
        public static string ChuanHoaXau(string xau)
        {
            string s = xau.Trim();
            while (s.IndexOf("  ") >= 0) s = s.Remove(s.IndexOf("  "), 1);
            string[] a = s.Split(' ');
            s = "";
            for (int i = 0; i < a.Length; ++i)
                s = s + " " + char.ToUpper(a[i][0]) + a[i].Substring(1).ToLower();
            return s.Trim();
        }
        public static string CatXau(string xau)
        {
            string s = xau.Trim();
            while (s.IndexOf("  ") >= 0) s = s.Remove(s.IndexOf("  "), 1);
            return s;
        }
        public static string ChuanHoaXau(string xau, int max)
        {
            string s = CatXau(xau);
            while (s.Length < max) s = s + " ";
            return s;
        }
    }
}