using System.Diagnostics;

namespace AdventOfCode;

public class Day02 : BaseDay
{
    private readonly string _input;
    
    public Day02()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public Day02(string input)
    {
        _input = input;
    }
    
    private enum E
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    private static E GetOpponentShape(string s) => s switch
    {
        "A" => E.Rock,
        "B" => E.Paper,
        "C" => E.Scissors,
        _ => throw new ArgumentOutOfRangeException()
    };

    private static int CalculateRoundScorePartOne(string s)
    {
        var res = 0;
        var p = s.Split(" ");
        Debug.Assert(p.Length == 2);
        var a = GetOpponentShape(p[0]);
        var x = p[1] switch
        {
            "X" => E.Rock,
            "Y" => E.Paper,
            "Z" => E.Scissors,
            _ => throw new ArgumentOutOfRangeException()
        };
        res += (int)x;
        if (a == x)
        {
            res += 3;
        }
        else if ((a == E.Rock && x == E.Paper) || (a == E.Paper && x == E.Scissors) || (a == E.Scissors && x == E.Rock))
        {
            res += 6;
        }
        return res;
    }

    private static int CalculateRoundScorePartTwo(string s)
    {
        var res = 0;
        var p = s.Split(" ");
        Debug.Assert(p.Length == 2);
        var a = GetOpponentShape(p[0]);
        res += p[1] switch
        {
            "X" => a switch
            {
                E.Rock => (int) E.Scissors,
                E.Paper => (int) E.Rock,
                E.Scissors => (int) E.Paper,
                _ => throw new ArgumentOutOfRangeException()
            },
            "Y" => 3 + (int) a,
            "Z" => a switch
            {
                E.Rock => (int) E.Paper,
                E.Paper => (int) E.Scissors,
                E.Scissors => (int) E.Rock,
                _ => throw new ArgumentOutOfRangeException()
            } + 6,
            _ => throw new ArgumentOutOfRangeException()
        };

        return res;
    }
    
    public override ValueTask<string> Solve_1() => new($"{_input.Split("\n").Select(CalculateRoundScorePartOne).Sum()}");
    
    public override ValueTask<string> Solve_2() => new($"{_input.Split("\n").Select(CalculateRoundScorePartTwo).Sum()}");
}
