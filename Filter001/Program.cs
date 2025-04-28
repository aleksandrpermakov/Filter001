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
            Console.WriteLine(Filter.NumberFilter(str)); // цифры
            FsWorker.AppendString(Filter.NumberFilter(str));

            Console.WriteLine(Filter.PunctuationFilter(str)); //знаки припенания
            FsWorker.AppendString(Filter.PunctuationFilter(str));

            Console.WriteLine(Filter.RussianSymbols(str));
            FsWorker.AppendString(Filter.RussianSymbols(str));

            Console.WriteLine(Filter.LatinCharacters(str));
            FsWorker.AppendString(Filter.LatinCharacters(str));

            myFilter delegats;
            delegats = Filter.NumberFilter;
            delegats += Filter.PunctuationFilter;
            delegats += Filter.RussianSymbols;
            delegats += Filter.LatinCharacters;
            delegats(str);









        }
    }
}
