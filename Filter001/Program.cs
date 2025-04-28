using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "12 4,Ъ F ГБ .5";
            ToFileDelegat toFileDelegat;
            Console.WriteLine(Filter.NumberFilter(str));
            string filter = Filter.NumberFilter(str);
            toFileDelegat = FsWorker.AppendString;
            toFileDelegat(filter);

            Console.WriteLine(Filter.PunctuationFilter(str));
            filter = Filter.PunctuationFilter(str);
            toFileDelegat(filter);
            
            Console.WriteLine(Filter.RussianSymbols(str));
            filter = Filter.RussianSymbols(str);
            toFileDelegat(filter);

            Console.WriteLine(Filter.LatinCharacters(str));
            filter = Filter.LatinCharacters(str);
            toFileDelegat(filter);


            myFilter delegats;
            delegats = Filter.NumberFilter;
            delegats += Filter.PunctuationFilter;
            delegats += Filter.RussianSymbols;
            delegats += Filter.LatinCharacters;
            delegats(str);









        }
    }
}
