using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_odd_number_from_20_to_100_by_using_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            do
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i++;

            }
            while (i <= 100);
        }
    }
}
