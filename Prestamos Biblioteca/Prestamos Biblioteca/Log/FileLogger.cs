using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Log
{
    public class FileLogger : LogBase
    {
        public string filePath = @"C:\Log.txt";
        public override void Log(string message)
        {
            lock (lockObj)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                {
                    streamWriter.WriteLine("[" + DateTime.Now + "] " + message);
                    streamWriter.Close();
                }
            }
        }
    }
}
