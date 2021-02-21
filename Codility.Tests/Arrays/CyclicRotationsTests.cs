using Codility.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Tests.Arrays
{
    [TestClass]
    public class CyclicRotationsTests
    {
        [TestMethod]
        public void SimpleRotations()
        {
            //Arrange
            var CyclicRotationSolver = new CyclicRotation();
            //Act
            var TestArray = new int[] { 3, 8, 9, 7, 6 };
            var RotatedArray = new int[] { 9, 7, 6, 3, 8 };
            var rotation = 3;

            //Test
            var rotationResult = CyclicRotationSolver.Solution(TestArray, rotation);

            Assert.AreEqual(rotationResult.Length, RotatedArray.Length);
            for (int i = 0; i < rotationResult.Length; i++)
            {
                Assert.AreEqual(rotationResult[i], RotatedArray[i]);
            }
        }

        [TestMethod]
        public void TwoElements()
        {
            //Arrange
            var CyclicRotationSolver = new CyclicRotation();
            //Act
            var TestArray = new int[] { 5, -1000 };
            var RotatedArray = new int[] { -1000, 5 };
            var rotation = 1;

            //Test
            var rotationResult = CyclicRotationSolver.Solution(TestArray, rotation);

            Assert.AreEqual(rotationResult.Length, RotatedArray.Length);
            for (int i = 0; i < rotationResult.Length; i++)
            {
                Assert.AreEqual(rotationResult[i], RotatedArray[i]);
            }
        }
    }
}
