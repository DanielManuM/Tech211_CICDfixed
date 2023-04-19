using ConsoleAppSortArray;

namespace Tests;

public class ArrayGeneratorTests
{
    [Test]
    public void GivenNumberReturnArrayOfThatLength()
    {
        Assert.That(ArrayGenerator.RandomArrayGenerator(10), Has.Length.EqualTo(10)); 
    }

    [Test]
    public void GivenNumberReturnArrayOfNumbersWithinRange()
    {
        var output = ArrayGenerator.RandomArrayGenerator(10);
        foreach (int num in output)
        {
            Assert.That(num, Is.GreaterThanOrEqualTo(-1000).And.LessThanOrEqualTo(1000));
        }         
    }
}
