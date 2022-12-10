namespace AdventOfCode;

public class Day00 : BaseDay
{
    private readonly string _input;
    
    public Day00()
    {
        _input = File.ReadAllText(InputFilePath);
    }
    
    public Day00(string input)
    {
        _input = input;
    }
    
    public override ValueTask<string> Solve_1() => new("");
    
    public override ValueTask<string> Solve_2() => new("");
}
