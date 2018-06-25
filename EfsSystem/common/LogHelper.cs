using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfsSystem.common
{
    public class LogHelper
    {
        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        #region static void WriteLog(Type t, Exception ex)

        public static void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);

        }

        #endregion

        public static void WriteLog(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error(msg);

        }

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        /// <param name="description"></param>
        public static void WriteLog(Type t, Exception ex, string description)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error(description, ex);
        }

        public static void WriteInfoLog(Type t, Exception ex, string description)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Info(description, ex);
        }

        public static void WriteInfoLog(Type t, string description)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Info(description);
        }

    }
}
