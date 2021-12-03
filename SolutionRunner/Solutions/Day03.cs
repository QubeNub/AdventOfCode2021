using Tidy.AdventOfCode;

namespace TestRunner.Solutions;

[Day(2021, 3)]
public class Day03 : Day<string[]>
{
    public int ByteLength = 12;
    
    public override string[] ParseInput(string rawInput)
    {
        return rawInput.Split('\n').ToArray();
    }

    public override object ExecutePart1()
    {
        string gamma = "", epsilon = "";
        var nrOfOnes = 0;
        var nrOfZeroes = 0;
        for (var o = 0; o < ByteLength; o++)
        {
            foreach (var b in Input)
            {
                nrOfOnes += b[o] == '1' ? 1 : 0;
                nrOfZeroes += b[o] == '0' ? 1 : 0;
            }

            if (nrOfOnes > nrOfZeroes)
            {
                gamma += '1';
                epsilon += '0';
            }
            else
            {
                gamma += '0';
                epsilon += '1';
            }
            
            nrOfOnes = 0;
            nrOfZeroes = 0;
        }
        
        return Convert.ToUInt16(gamma, 2) * Convert.ToUInt16(epsilon, 2);
    }

    public override object ExecutePart2()
    {
        throw new NotImplementedException();
    }
}