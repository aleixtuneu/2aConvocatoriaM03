using Convocatoria2;

namespace ExerciseTwentythreeT2Tests
{
    [TestClass]
    public class NumberUtilsTests
    {
        [TestMethod]
        public void IsEven_InputIsPositiveEven_ShouldReturnTrue()
        {
            // Arrange
            int numberToTest = 4;
            bool expectedOutcome = true;

            // Act
            bool actualOutcome = NumberUtils.IsEven(numberToTest);

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome, $"El número {numberToTest} hauria de ser parell.");
        }

        [TestMethod]
        public void IsEven_InputIsPositiveOdd_ShouldReturnFalse()
        {
            // Arrange
            int numberToTest = 7;
            bool expectedOutcome = false;

            // Act
            bool actualOutcome = NumberUtils.IsEven(numberToTest);

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome, $"El número {numberToTest} hauria de ser senar.");
        }

        [TestMethod]
        public void IsEven_InputIsZero_ShouldReturnTrue()
        {
            // Arrange
            int numberToTest = 0;
            bool expectedOutcome = true;

            // Act
            bool actualOutcome = NumberUtils.IsEven(numberToTest);

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome, "El número 0 hauria de ser considerat parell.");
        }

        [TestMethod]
        public void IsEven_InputIsNegativeEven_ShouldReturnTrue()
        {
            // Arrange
            int numberToTest = -6;
            bool expectedOutcome = true;

            // Act
            bool actualOutcome = NumberUtils.IsEven(numberToTest);

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome, $"El número {numberToTest} hauria de ser parell.");
        }

        [TestMethod]
        public void IsEven_InputIsNegativeOdd_ShouldReturnFalse()
        {
            // Arrange
            int numberToTest = -5;
            bool expectedOutcome = false;

            // Act
            bool actualOutcome = NumberUtils.IsEven(numberToTest);

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome, $"El número {numberToTest} hauria de ser senar.");
        }

        [DataTestMethod]
        [DataRow(2, true, "El número 2 és parell")]
        [DataRow(100, true, "El número 100 és parell")]
        [DataRow(1, false, "El número 1 és senar")]
        [DataRow(101, false, "El número 101 és senar")]
        [DataRow(0, true, "El número 0 és parell")]
        [DataRow(-2, true, "El número -2 és parell")]
        [DataRow(-1, false, "El número -1 és senar")]
        public void IsEven_MultipleCases_UsingDataRow(int number, bool expected, string messageOnError)
        {
            // Arrange (els valors 'number' i 'expected' venen de DataRow)

            // Act
            bool actual = NumberUtils.IsEven(number);

            // Assert
            Assert.AreEqual(expected, actual, messageOnError);
        }
    }
}