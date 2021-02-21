using Codility.Iterations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tests.Arrays
{
    [TestClass]
    public class OddOcurrencesInArrayTests
    {
        [TestMethod]
        public void TestOddOcurrences()
        {
            int[] sampleArray = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            var OddOccurrencesSolver = new OddOccurrencesInArray();

            var solution =  OddOccurrencesSolver.Solution(sampleArray);

            Assert.AreEqual(solution, 7);
        }
    }
}
