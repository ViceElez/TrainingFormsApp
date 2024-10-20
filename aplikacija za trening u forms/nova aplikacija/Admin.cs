using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nova_aplikacija
{
    public static class Admin
    {
        public static List<string> Vjezbe()
        {
            List<string> vjezbe = new List<string>();
            StreamReader sr1 = new StreamReader("vjezbe.txt");
            string linija;
            bool kraj = false;
            while (kraj != true)
            {
                linija = sr1.ReadLine();
                if (linija == null)
                {
                    kraj = true;
                }

                else
                {
                    vjezbe.Add(linija);
                }
            }
            sr1.Close();
            return vjezbe;
        }

        
    }
}  
