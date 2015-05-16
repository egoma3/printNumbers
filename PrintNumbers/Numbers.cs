using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    public class Numbers
    {
       
            public static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 3; i <= 117; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sum += 15;

                }
                else if (i % 3 == 0)
                {
                    sum += 3;
                }
                else if (i % 5 == 0)
                {
                    sum += 5;
                }
                else
                {
                    sum += 1;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
   
}
