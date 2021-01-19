using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.StaticExtensions.Extensions
{
    /// <summary>
    /// 时间转换拓展
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 当前时区
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static long ConvertDataTimeToLong(this DateTime dt)
        {
            DateTime dtStart = new DateTime(1997, 1, 1).ToLocalTime();
            dt = dt.ToLocalTime();
            TimeSpan toNow = dt.Subtract(dtStart);
            long timeStamp = toNow.Ticks;
            // 1Ticks = 100纳秒
            //转换成毫秒
            timeStamp = timeStamp / 10000;
            return timeStamp;
        }
        /// <summary>
        /// 时间戳转时间
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static DateTime ConvertLongToDateTime(this long d)
        {
            DateTime dtStart = new DateTime(1997, 1, 1).ToLocalTime();
            long lTime = d*10000;
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime dtResult = dtStart.Add(toNow);
            return dtResult;
        }
    }
}
