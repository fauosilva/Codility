using Codility.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tests.TimeComplexity
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        public void TestShortTape()
        {
            var tapeEquilibriumSolver = new TapeEquilibrium();

            int maxElement = 10;
            List<int> entryArray = new List<int>();
            for (int i = 0; i < maxElement; i++)
            {
                entryArray.Add(i + 1);
            }

            int solution = tapeEquilibriumSolver.solution(entryArray.ToArray());
            Assert.AreEqual(solution, 1);
        }


        [TestMethod]
        public void TestShortTapeSample()
        {
            var tapeEquilibriumSolver = new TapeEquilibrium();
            List<int> entryArray = new List<int>() { 3, 1, 2, 4, 3 };
        
            int solution = tapeEquilibriumSolver.solution(entryArray.ToArray());
            Assert.AreEqual(solution, 1);
        }

        [TestMethod]
        public void TestShortTapeSkipingOneElement()
        {
            var tapeEquilibriumSolver = new TapeEquilibrium();

            int maxElement = 10;
            List<int> entryArray = new List<int>();
            for (int i = 0; i < maxElement; i++)
            {
                entryArray.Add(i + 1);
            }

            var rnd = new Random();
            int randomMissingElement = rnd.Next(1, maxElement);
            entryArray.RemoveAt(randomMissingElement - 1);

            int solution = tapeEquilibriumSolver.solution(entryArray.ToArray());
            Assert.AreEqual(solution, 1);
        }
    }
}
