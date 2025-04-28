using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter001
{
    delegate string myFilter(string text);
    public class FsWorker
    {
        static public bool AppendString(myFilter name)
        {
            string str = name;
            try
            {
                using (StreamWriter sw = new StreamWriter("out.txt", true))
                {
                    sw.WriteLine(_str);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
