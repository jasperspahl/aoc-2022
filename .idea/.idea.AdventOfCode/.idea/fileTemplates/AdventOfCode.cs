namespace AdventOfCode;

public class Day${NAME} : BaseDay
{
    private readonly string _input;
    
    public Day${NAME}()
    {
        _input = File.ReadAllText(InputFilePath);
    }
    
    public Day${NAME}(string input)
    {
        _input = input;
    }
    
    public override ValueTask<string> Solve_1() => new("");
    
    public override ValueTask<string> Solve_2() => new("");
}
