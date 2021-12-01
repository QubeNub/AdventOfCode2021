using Tidy.AdventOfCode;

namespace TestRunner.Solutions;

[Day(2021, 1)]
public class Day01 : Day.NewLineSplitParsed<int>
{
    public override int[] ParseInput(string rawInput)
    {
        return rawInput.Split('\n').Select(int.Parse).ToArray();
    }

    public override object ExecutePart1()
    {
        var increases = 0;
        var prev = 0;
        foreach (var i in Input)
        {
            increases += DoesIncrease(i, prev);
            prev = i;
        }
        return increases;
    }

    public override object ExecutePart2()
    {
        var increases = 0;
        var prev = 0;
        for (var i = 0; i < Input.Length - 2; i++)
        {
            var sum = Input[i] + Input[i + 1] + Input[i + 2];
            increases += DoesIncrease(sum, prev);
            prev = sum;
        }
        return increases;
    }
    
    private static int DoesIncrease(int n, int p = 0)
    {
        if(p == 0)
        {
            return 0;
        }

        return p < n ? 1 : 0;
    }
}