using MarsRoverConsole;
using NUnit.Framework.Constraints;

namespace MarsRoverTests;

public class TmpSolutionTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("55", "12N", "LMLMLMLMM", "13N")]
    [TestCase("55", "33E", "MMRMMRMRRM", "51E")]
    public void TmpTest(object upperRightPlateauCoordinates, object initialRoverPosition, object instructions, object expectedFinalPosition)
    {
        var actualFinalPosition = TmpSolution.Tmp();
        Assert.That(actualFinalPosition, Is.EqualTo(expectedFinalPosition));
    }
}