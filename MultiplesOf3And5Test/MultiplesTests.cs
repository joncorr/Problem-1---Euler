using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplesOf3And5Test;
using System.Collections.Generic;
using MultiplesOf3And5;

namespace MultiplesOf3And5Test
{
    [TestClass]
    public class MultiplesTests
    {
        [TestMethod]
        public void GetMultiplesOf3and5_Under10()
        {
            MultiplesOf3and5 multiples = new MultiplesOf3and5();

            List<int> expected = new List<int>() { 3, 5, 6, 9 };
            List<int> listOfMultiples = multiples.GetMultiplesOf3and5(under: 10);


            CollectionAssert.AreEqual(expected, listOfMultiples); 
        }

        [TestMethod]
        public void GetMultiples_Of3Under10()
        {
            MultiplesOf3and5 multiples = new MultiplesOf3and5();

            List<int> expected = new List<int>() { 3, 6, 9 };
            List<int> multiplesOf3 = multiples.GetMultiples(of:3, under: 10);

            CollectionAssert.AreEqual(expected, multiplesOf3); 

        }

        [TestMethod]
        public void GetMultiples_Of5Under10()
        {
            MultiplesOf3and5 multiples = new MultiplesOf3and5();

            List<int> expected = new List<int>() { 5 };
            List<int> multiplesOf5 = multiples.GetMultiples(of: 5, under: 10);

            CollectionAssert.AreEqual(expected, multiplesOf5);
        }

        [TestMethod]
        public void GetSum_OfMultiplesOf3and5_Under10()
        {
            MultiplesOf3and5 multiples = new MultiplesOf3and5();

            List<int> multiplesOf3and5 = multiples.GetMultiplesOf3and5(10);

            int expected = 23;
            int actual = multiples.GetSum(multiplesOf3and5);


            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void GetSumOfMultiuplesOf3And5_Under10()
        {
            MultiplesOf3and5 multiples = new MultiplesOf3and5();

            int expected = 23;
            int actual = multiples.GetSumOfMultiplesOf3and5(under: 10);

            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void GetSumOfMultiuplesOf3And5_Under1000()
        {
            MultiplesOf3and5 multiples = new MultiplesOf3and5();

            int expected = 233168;
            int actual = multiples.GetSumOfMultiplesOf3and5(under: 1000);

            Assert.AreEqual(expected, actual);
        }
    }
}
