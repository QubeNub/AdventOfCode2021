using System;
using NUnit.Framework;
using TestRunner.Solutions;

namespace SolutionTests;

public class Day03Tests
{
    private Day03 _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new Day03();
        _sut.ByteLength = 5;
        _sut.Input = new[]
        {
           "00100",
           "11110",
           "10110",
           "10111",
           "10101",
           "01111",
           "00111",
           "11100",
           "10000",
           "11001",
           "00010",
           "01010"
        };
    }

    [Test]
    public void TestPart1()
    {
        var result = _sut.ExecutePart1();
        Assert.AreEqual(198, result);
    }

    [Test]
    public void TestPart2()
    {
        var result = _sut.ExecutePart2();
        Assert.AreEqual(900, result);
    }
}