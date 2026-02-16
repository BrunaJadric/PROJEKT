using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PROJEKT
{
    public static class Admin
    {
        public static void UnosZivotinje(string zapis)
        {
           
            StreamWriter sw = new StreamWriter("azil.txt", true);
            sw.WriteLine(zapis);
            sw.Close();

        }
    }
}
