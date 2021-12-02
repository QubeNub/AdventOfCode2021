using System.Collections.Generic;
using NUnit.Framework;
using TestRunner.Solutions;

namespace SolutionTests;

public class Day02Tests
{
    private Day02 _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new Day02();
        _sut.Input = new List<(string, int)>
        {
            ("forward ", 5),
            ("down ", 5),
            ("forward ", 8),
            ("up ", 3),
            ("down ", 8),
            ("forward ", 2)
        };
    }

    [Test]
    public void TestPart1()
    {
        var result = _sut.ExecutePart1();
        Assert.AreEqual(150, result);
    }

    [Test]
    public void TestPart2()
    {
        var result = _sut.ExecutePart2();
        Assert.AreEqual(900, result);
    }
}