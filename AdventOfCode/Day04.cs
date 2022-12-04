using System.Diagnostics;
using System.Linq;

namespace AdventOfCode;

public class Day04 : BaseDay
{
    private readonly string _input;
    
    public Day04()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public Day04(string input)
    {
        _input = input;
    }

    private static int[][] Split(string s) =>
        s.Split(",").Select(s => s.Split("-").Select(int.Parse).ToArray()).ToArray();

    private static bool CalculatePartOne(string input)
    {
        var s = Split(input);
        Debug.Assert(s.Length == 2, nameof(s) + ".Length == 2");
        return s[0][0] >= s[1][0] && s[0][1] <= s[1][1] ||
               s[1][0] >= s[0][0] && s[1][1] <= s[0][1];
    }

    public override ValueTask<string> Solve_1() => new($"{_input.Split("\n").Where(CalculatePartOne).Count()}");
    
    private static bool CalculatePartTwo(string input)
    {
        var s = Split(input);
        return s[1][0] <= s[0][0] && s[0][0] <= s[1][1] ||
               s[1][0] <= s[0][1] && s[0][1] <= s[1][1] ||
               s[0][0] <= s[1][0] && s[1][0] <= s[0][1] ||
               s[0][0] <= s[1][0] && s[1][0] <= s[0][1];
    }
    
    public override ValueTask<string> Solve_2() => new($"{_input.Split("\n").Where(CalculatePartTwo).Count()}");

}
