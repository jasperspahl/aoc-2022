namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly List<string> _input;
    private readonly List<int> _elves;

    public Day01()
    {
        _input = File.ReadAllLines(InputFilePath).ToList();
        _elves = new List<int> {0};
        var curr = 0;
        foreach (var line in _input)
        {
            if (line == "")
            {
                curr++;
                _elves.Add(0);
            }
            else
            {
                _elves[curr] += int.Parse(line);
            }
        }
    }
    
    public override ValueTask<string> Solve_1() => new($"{_elves.Max()}");
    
    public override ValueTask<string> Solve_2() => new($"{_elves.OrderByDescending(n=>n).Take(3).Sum()}");
}