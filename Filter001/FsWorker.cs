﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter001
{
    public delegate string myFilter(string text);
    public delegate void ToFileDelegat(string text);

    public class FsWorker
    {
        static public void AppendString(string str)
        {
           

            try
            {
                using (StreamWriter sw = new StreamWriter("out.txt", true))
                {
                    sw.WriteLine(str);
                }
                
            }
            catch
            {
                Console.WriteLine("Ошибка записи в фаил");
               
            }
        }
    }
}
