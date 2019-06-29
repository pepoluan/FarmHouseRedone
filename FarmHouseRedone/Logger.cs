﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;

namespace FarmHouseRedone
{
    public static class Logger
    {
        public static IMonitor monitor;
        public static bool suppressTrace;

        public static void Log(string log, LogLevel level = LogLevel.Trace)
        {
            if (monitor == null)
                return;
            if (Logger.suppressTrace && (level == LogLevel.Trace))
                return;
            monitor.Log(log, level);
        }
    }
}
