using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа "отражает" введенное предложение наоборот
            var str = "My Name is Esimzhan".ToCharArray();
            Array.Reverse(str);
            var res = String.Concat(str);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
