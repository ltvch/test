using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStruct
{
    struct Num
    {
        public int i;
    }

    class Program
    {
        public static void Update(Num y)
        {
            y.i = 20;
            Console.WriteLine(y.i);//20
        }

        static void Main(string[] args)
        {
            Num x = new Num();
            x.i = 10;
            Update(x);
            Console.Write(x.i);//10


            Console.Read();
        }
    }
}
