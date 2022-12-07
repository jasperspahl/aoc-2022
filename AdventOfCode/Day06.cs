namespace AdventOfCode;

public class Day06 : BaseDay
{
    private readonly string _input;
    
    public Day06()
    {
        _input = File.ReadAllText(InputFilePath);
    }
    
    public Day06(string input)
    {
        _input = input;
    }

    private static bool AreCharsUnique(string str)
    {
        int checker = 0;

        foreach (var c in str)
        {
            var val = c - 'a';
            if ((checker & (1 << val)) > 0)
                return false;

            checker |= 1 << val;
        }
        return true;
    }

    public override ValueTask<string> Solve_1()
    {
        int i = 0;
        int j = 4;
        var slice = _input[i..j];
        while (!AreCharsUnique(slice))
        {
            i++;
            j++;
            slice = _input[i..j];
        }

        return new($"{j}");
    }

    public override ValueTask<string> Solve_2()
    {
        int i = 0;
        int j = 14;
        var slice = _input[i..j];
        while (!AreCharsUnique(slice))
        {
            i++;
            j++;
            slice = _input[i..j];
        }

        return new($"{j}");
    }
}