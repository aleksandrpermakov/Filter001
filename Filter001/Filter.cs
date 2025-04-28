using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter001
{
    public class Filter
    {
         public static string NumberFilter(string str)
        {
            string tmp = string.Empty;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9') 
                {
                    tmp += str[i];
                }
            }
            return tmp;
        }
        public static string PunctuationFilter(string str)
        {
            string tmp = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]))
                {
                    tmp += str[i];
                }
            }
            return tmp;
        }
        public static string RussianSymbols(string str)
        {
            string tmp = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'А' && str[i] <= 'я')
                {
                    tmp += str[i];
                }
            }
            return tmp;
        }
        public static string LatinCharacters(string str)
        {
            string tmp = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'z')
                {
                    tmp += str[i];
                }
            }
            return tmp;
        }
    }
}
