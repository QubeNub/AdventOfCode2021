using NUnit.Framework;
using TestRunner.Solutions;

namespace SolutionTests;

public class Day01Tests
{
    private Day01 _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new Day01();
        _sut.Input = new[]
        {
            199,
            200,
            208,
            210,
            200,
            207,
            240,
            269,
            260,
            263
        };
    }

    [Test]
    public void TestPart1()
    {
        var result = _sut.ExecutePart1();
        Assert.AreEqual(7, result);
    }

    [Test]
    public void TestPart2()
    {
        var result = _sut.ExecutePart2();
        Assert.AreEqual(5, result);
    }
}