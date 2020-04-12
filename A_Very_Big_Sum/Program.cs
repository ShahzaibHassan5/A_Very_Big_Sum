using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Size of Array :");
            int size=int.Parse(Console.ReadLine());
            Int64[] newArray = new Int64[size];
            Console.WriteLine("Enter Elements of Array ");
            for(int i=0;i<newArray.Length;i++)
            {
                newArray[i] = Int64.Parse(Console.ReadLine());
            }
            Int64 sumOfArray = 0;
            for(int i=0;i<newArray.Length;i++)
            {
                sumOfArray += newArray[i];
            }
            Console.WriteLine("Sum of Array Is :"+sumOfArray);
            Console.Read();


        }
    }
}
