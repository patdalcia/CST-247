using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Utility
{
    public interface ILogger
    {
        void Info(String message, String arg = null);
        void Debug(String message, String arg = null);
        void Warning(String message, String arg = null);
        void Error(String message, String arg = null);
    }
}