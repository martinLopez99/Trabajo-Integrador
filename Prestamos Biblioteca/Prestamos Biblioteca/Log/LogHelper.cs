using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Log
{
    public static class LogHelper
    {
        private static LogBase logger = null;
        public static void Log(LogTarget target, string message)
        {
            switch (target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(message);
                    break;
                default:
                    return;
            }
        }
    }
}
