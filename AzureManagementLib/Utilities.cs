using System;
using System.Collections.Generic;
using System.Text;

namespace AzureManagementLib
{
    /// <summary>
    /// The static lass of utilities that are called by either the demo or WebAPI
    /// The class does not include instance of Azure Management Fluent API
    /// </summary>
    public static class Utilities
    {
        public static Action<string> LoggerMethod { get; set; }

        static Utilities()
        {
            // LoggerMethod = Console.WriteLine;
        }

        public static void Log(string message)
        {
            if (null == LoggerMethod)
            {
                throw new MissingMemberException("LoggerMethod not set");
            } else {
                LoggerMethod.Invoke(message);
            }
        }

        public static void Log(object obj)
        {
            if (null == LoggerMethod)
            {
                throw new MissingMemberException("LoggerMethod not set");
            }
            else
            {
                if (obj != null)
                {
                    LoggerMethod.Invoke(obj.ToString());
                }
                else
                {
                    LoggerMethod.Invoke("(null)");
                }
            }
        }

        public static void Log()
        {
                Utilities.Log("");
        }
    }
}

