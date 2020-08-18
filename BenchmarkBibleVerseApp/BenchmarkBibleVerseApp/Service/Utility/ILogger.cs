using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenchmarkBibleVerseApp.Service.Utility
{
    public interface ILogger
    {
        void Debug(String message, String arg = null);
        void Info(String message, String arg = null);
        void Warning(String message, String arg = null);
        void Error(String message, String arg = null);
    }
}