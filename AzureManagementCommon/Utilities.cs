﻿using System;
using System.Collections.Generic;
using System.Text;

// adapted from azure-sdk-for-net/Samples/Common/Utilities.cs

namespace AzureManagementCommon
{
    /// <summary>
    /// The static lass of utilities that are called by either the demo or WebAPI
    /// The class does not include instance of Azure Management Fluent API
    /// </summary>
    public static class Utilities
    {
        #region Logger
        public static Action<string> LoggerMethod { get; set; }

        /// <summary>
        /// Sets default logger method
        /// </summary>
        static Utilities()
        {
            // Change from Console.WriteLine;
        }

        public static void Log(string message)
        {
            LoggerMethod.Invoke(message);
        }

        public static void Log(object obj)
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

        public static void Log()
        {
            Utilities.Log("");
        }
        #endregion
    }
}
