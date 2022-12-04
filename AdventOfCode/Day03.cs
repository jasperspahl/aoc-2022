namespace AdventOfCode;

public class Day03 : BaseDay
{
    private readonly string _input;
    
    public Day03()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public Day03(string input)
    {
        _input = input;
    }

    private static int GetValueOfChar(char c)
    {
            var i = (int) c;
            return i switch
            {
                > 64 and <= 90 => i - 38,
                >= 97 and <= 122 => i - 96,
                _ => throw new ArgumentOutOfRangeException()
            };
    }

    private static int CalculatePartOne(string input)
    {
        var r = input[(input.Length / 2)..] ?? throw new ArgumentNullException("input[(input.Length / 2)..]");
        return input.Take(input.Length / 2).Where(c => r.Contains(c)).Select(GetValueOfChar).First();
    }
    
    public override ValueTask<string> Solve_1() => new($"{_input.Split("\n").Select(CalculatePartOne).Sum()}");
    
    public override ValueTask<string> Solve_2()
    {
        var result = 0;
        var elfs = _input.Split("\n");
        for (var i = 0; i < elfs.Length; i+=3)
        {
            var elf = elfs[i];
            result += elf[..].Where(c => elfs[i + 1].Contains(c) && elfs[i + 2].Contains(c)).Select(GetValueOfChar).First();
        }
        return new ValueTask<string>($"{result}");
    }
}
