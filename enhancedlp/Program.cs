using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enhancedlp
{
    class demo
    {
        int sum = 0;
        public int add(int[] list)
        {
            foreach(int x in list)
            {
                sum = sum + x;   
            }
            return sum;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 19, 33, 45, 54, 23, 78, 12 };
            demo d1 = new demo();
            int res = d1.add(lst);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
