using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplesOf3and5 multipleOf3and5 = new MultiplesOf3and5();

            List<int> multiplesOf3and5under1000 = multipleOf3and5.GetMultiplesOf3and5(1000);

            Console.Write("Multiples:"); 
            multiplesOf3and5under1000.ForEach(x => Console.Write(x + ","));
            Console.WriteLine(); 
           

            int sum = multipleOf3and5.GetSumOfMultiplesOf3and5(1000);

            Console.Write("Sum:");
            Console.WriteLine(sum); 

            Console.WriteLine("Press any key to continue..."); 
            Console.ReadKey(); 
        }
    }
}
