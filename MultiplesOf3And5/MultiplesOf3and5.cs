using System;
using System.Collections.Generic;


namespace MultiplesOf3And5
{
    public class MultiplesOf3and5
    {       

        public List<int> GetMultiplesOf3and5(int under)
        {
            List<int> multiples = new List<int>();

            multiples.AddRange(GetMultiples(3, under));  
            
            foreach(int x in GetMultiples(5, under))
            {
                if (!multiples.Contains(x))
                    multiples.Add(x);
            }
         

            
            multiples.Sort();

            return multiples; 
        }

        public List<int> GetMultiples(int of, int under)
        {
            List<int> multiples = new List<int>(); 
            for (int x = 1; x < under; x++)
            {
                if (x % of == 0)
                {
                    multiples.Add(x);
                }
            }

            return multiples;
        }

        public int GetSum(List<int> multiples)
        {
            int sum = 0;

            foreach (int x in multiples)
                sum += x;

            return sum; 
        }

        public int GetSumOfMultiplesOf3and5(int under)
        {           
            List<int> multiples = GetMultiplesOf3and5(under);

            int sum = 0;
            sum = GetSum(multiples);

            return sum; 
        }
    }
}