/****
 * Writen by Nolan Meehan
 * Displays 1-20 as well as the binary equivalent
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u5BinaryNumbersNolan
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <21;i++)
            {
                Console.WriteLine(String.Format("{0}    {1}",i, Convert.ToString(i,2)));
            }
            Console.ReadLine();
        }
    }
}
