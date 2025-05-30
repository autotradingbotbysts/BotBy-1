﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbestTradeBot.Client.EventArgs
{
    public class LogEventArgs : System.EventArgs
    {
        public string Message { get; set; } = string.Empty;
        public LogEventArgs(string message)
        {
            Message = message;
        }
    }
}
