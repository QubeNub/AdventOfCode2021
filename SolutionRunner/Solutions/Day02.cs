using TestRunner.Helpers;
using Tidy.AdventOfCode;

namespace TestRunner.Solutions;


[Day(2021, 2)]
public class Day02 : Day<IEnumerable<(string, int)>>
{
    public override IEnumerable<(string, int)> ParseInput(string rawInput)
    {
        return rawInput.Split('\n').Select(r =>
        {
            var x = r.Split(' ');
            return (x[0], int.Parse(x[1]));
        });
    }

    public override object ExecutePart1()
    {
        var submarine = new Submarine();
        foreach (var command in Input)
        {
            submarine.ExecuteCommand(command);
        }
        return submarine.GetFinalLocation();
    }

    public override object ExecutePart2()
    {
        var submarine = new SubmarineWithAim();
        foreach (var command in Input)
        {
            submarine.ExecuteCommand(command);
        }
        return submarine.GetFinalLocation();
    }
}