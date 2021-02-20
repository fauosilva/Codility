using Codility.Iterations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Tests
{
    [TestClass]
    public class BinaryGapTests
    {
        [TestMethod]
        public void BinaryGapZeroIfNotBetweenTwoOnes()
        {
            //Arrange
            var BinaryGapSolver = new BinaryGap(); 
            //Act
            //Test
            Assert.AreEqual(0, BinaryGapSolver.Solution(1));
            Assert.AreEqual(0, BinaryGapSolver.Solution(2));
            Assert.AreEqual(0, BinaryGapSolver.Solution(32));
        }

        [TestMethod]
        public void BinaryGapZeroIfNotFound()
        {
            //Arrange
            var BinaryGapSolver = new BinaryGap();
            //Act
            //Test
            Assert.AreEqual(0, BinaryGapSolver.Solution(15));
        }

        [TestMethod]
        public void BinaryGapCorrectIfNotTwoOnes()
        {
            //Arrange
            var BinaryGapSolver = new BinaryGap();
            //Act
            //Test
            Assert.AreEqual(4, BinaryGapSolver.Solution(33));
        }

        [TestMethod]
        public void MaximumBinaryGapOfTwoGapsShouldBeReturned()
        {
            //Arrange
            var BinaryGapSolver = new BinaryGap();
            //Act
            //Test
            Assert.AreEqual(4, BinaryGapSolver.Solution(133));
            Assert.AreEqual(4, BinaryGapSolver.Solution(2123));
        }

    }

}
