using Codility.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Codility.Tests.TimeComplexity
{
    [TestClass]
    public class PermMissingElemTests
    {
        [TestMethod]
        public void LongArrayTest()
        {
            int maxElement = 100000;
            int[] entryArray = new int[maxElement - 1];
            for (int i = 1; i < maxElement ; i++)
            {
                entryArray[i-1] = i + 1;
            }
          
            var permMissingSolver = new PermMissingElem();
            int solution = permMissingSolver.solution(entryArray);
            Assert.AreEqual(solution,1);
        }

        [TestMethod]
        public void LongMissingRandomElement()
        {
            var permMissingSolver = new PermMissingElem();

            int maxElement = 100000;
            List<int> entryArray = new List<int>();
            for (int i = 0; i < maxElement; i++)
            {
                entryArray.Add(i + 1);
            }

            var rnd = new Random();
            int randomMissingElement = rnd.Next(1, maxElement);
            entryArray.RemoveAt(randomMissingElement - 1);

            int solution = permMissingSolver.solution(entryArray.ToArray());
            Assert.AreEqual(solution, randomMissingElement);
        }

        [TestMethod]
        public void ShortArrayMissingFirstElement()
        {
            var permMissingSolver = new PermMissingElem();

            int maxElement = 5;
            int[] entryArray = new int[maxElement - 1];
            for (int i = 1; i < maxElement; i++)
            {
                entryArray[i - 1] = i + 1;
            }

            int solution = permMissingSolver.solution(entryArray);
            Assert.IsTrue(solution == 1);


            maxElement = 1000;
            entryArray = new int[maxElement - 1];
            for (int i = 1; i < maxElement; i++)
            {
                entryArray[i - 1] = i + 1;
            }

            solution = permMissingSolver.solution(entryArray);
            Assert.IsTrue(solution == 1);
        }

        [TestMethod]
        public void ShortArrayMissingRandomElement()
        {
            var permMissingSolver = new PermMissingElem();

            int maxElement = 100;
            List<int> entryArray = new List<int>();
            for (int i = 0; i < maxElement; i++)
            {
                entryArray.Add(i + 1);
            }

            var rnd = new Random();
            int randomMissingElement = rnd.Next(1, maxElement);
            entryArray.RemoveAt(randomMissingElement - 1 );

            int solution = permMissingSolver.solution(entryArray.ToArray());
            Assert.AreEqual(solution,randomMissingElement);
        }
    }
}
