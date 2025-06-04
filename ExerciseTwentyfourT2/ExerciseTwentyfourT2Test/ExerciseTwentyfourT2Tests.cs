using Xunit;
using Convocatoria2;

public class ExerciseTwentyfourT2Tests
{
    [Fact]
    public void IsOdd_InputIsPositiveOdd_ShouldReturnTrue()
    {
        // Arrange
        int numberToTest = 7;
        bool expectedOutcome = true;

        // Act
        bool actualOutcome = NumberUtils.IsOdd(numberToTest);

        // Assert
        Assert.Equal(expectedOutcome, actualOutcome);
    }

    [Fact]
    public void IsOdd_InputIsPositiveEven_ShouldReturnFalse()
    {
        // Arrange
        int numberToTest = 4;
        bool expectedOutcome = false;

        // Act
        bool actualOutcome = NumberUtils.IsOdd(numberToTest);

        // Assert
        Assert.Equal(expectedOutcome, actualOutcome);
    }

    [Fact]
    public void IsOdd_InputIsZero_ShouldReturnFalse() // El 0 es considera parell, per tant no senar
    {
        // Arrange
        int numberToTest = 0;
        bool expectedOutcome = false;

        // Act
        bool actualOutcome = NumberUtils.IsOdd(numberToTest);

        // Assert
        Assert.False(actualOutcome, "El número 0 no hauria de ser considerat senar.");
    }

    [Fact]
    public void IsOdd_InputIsNegativeOdd_ShouldReturnTrue()
    {
        // Arrange
        int numberToTest = -5;
        bool expectedOutcome = true;

        // Act
        bool actualOutcome = NumberUtils.IsOdd(numberToTest);

        // Assert
        Assert.True(actualOutcome, $"El número {numberToTest} hauria de ser senar.");
    }

    [Fact]
    public void IsOdd_InputIsNegativeEven_ShouldReturnFalse()
    {
        // Arrange
        int numberToTest = -6;
        bool expectedOutcome = false;

        // Act
        bool actualOutcome = NumberUtils.IsOdd(numberToTest);

        // Assert
        Assert.False(actualOutcome, $"El número {numberToTest} hauria de ser parell (no senar).");
    }

    [Theory]
    [InlineData(1, true)]
    [InlineData(101, true)]
    [InlineData(-3, true)]
    [InlineData(2, false)]
    [InlineData(100, false)]
    [InlineData(0, false)] // El 0 no és senar
    [InlineData(-4, false)]
    public void IsOdd_MultipleCases_UsingTheoryAndInlineData(int number, bool expected)
    {
        // Arrange (els valors 'number' i 'expected' venen de InlineData)

        // Act
        bool actual = NumberUtils.IsOdd(number);

        // Assert
        Assert.Equal(expected, actual);
    }
}