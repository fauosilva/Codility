using Codility.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Tests.TimeComplexity.cs
{
    [TestClass]
    public class FrogJmpTests
    {
        [TestMethod]
        public void TestFrogJmp()
        {
            var frogJmpSolver = new FrogJmp();

            var solution = frogJmpSolver.solution(1, 10, 2);

            Assert.AreEqual(solution, 5);
        }
    }
}
