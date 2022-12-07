namespace AdventOfCode;

public class Day05 : BaseDay
{
    private readonly string _input;
    
    public Day05()
    {
        _input = File.ReadAllText(InputFilePath);
    }
    
    public Day05(string input)
    {
        _input = input;
    }

    private static Dictionary<int, Stack<char>> ParseState(string initState)
    {
        var l = new Dictionary<int, Stack<char>>();
        var lu = new List<int>();
        var rows = initState.Split("\n").Reverse().ToList();
        var indexRow = rows[0];
        foreach (int i in indexRow.Split(" ").Where(x => x!= "").Select(int.Parse))
        {
            Console.Write($"{i} ");
            l[i] = new Stack<char>();
            lu.Add(i);
        }

        for (int i = 1; i < rows.Count; i++)
        {
            for (int j = 0; j < rows[i].Length; j+=4)
            {
                var container = rows[i][j+1];
                if (container == 32) continue;
                l[lu[j / 4]].Push(container);
            }
        }
        return l;
    }

    private (Dictionary<int, Stack<char>> state, (int count, int from, int to)[] instructions) ParseInput()
    {
        var sections = _input.Split("\n\n");
        var state = ParseState(sections[0]);
        var instructions = sections[1].Split("\n").Where(s => s.Length > 0)
            .Select(s =>
            {
                
                var p = s.Split(" ");
                return (count: int.Parse(p[1]), from: int.Parse(p[3]), to: int.Parse(p[5]));
            }
            ).ToArray();
        return (state, instructions);
    }

    public override ValueTask<string> Solve_1()
    {
        var (state, instructions) = ParseInput();
        foreach (var i in instructions)
        {
            // move x from y to z
            for (int j = 0; j < i.count; j++)
            {
                var c = state[i.from].Pop();
                state[i.to].Push(c);
            }
        }

        var s = state.Keys.Aggregate("", (current, key) => current + state[key].Peek());
        return new(s);
    }

    public override ValueTask<string> Solve_2()
    {
        var (state, instructions) = ParseInput();
        
        Stack<char> t;
        foreach (var instruction in instructions)
        {
            t = new();
            for (int i = 0; i < instruction.count; i++)
            {
                t.Push(state[instruction.from].Pop());
            }
            for (int i = 0; i < instruction.count; i++)
            {
                state[instruction.to].Push(t.Pop());
            }
        }
        return new(state.Keys.Aggregate("", (current, key) => current + state[key].Peek()));
    }
}
