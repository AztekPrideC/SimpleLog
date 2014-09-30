using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLog
{
    public static class Log
    {
        public static void Registro(DateTime fecha, int status, String operacion, String descripcion)
        {
            File.AppendAllText("log.txt", fecha+" | "+status+" "+operacion+" "+descripcion);
        }
    }
}
