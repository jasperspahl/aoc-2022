using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Tests;

public class Day05Test
{
    private readonly Day05 _sub;

    public Day05Test()
    {
        const string inputText = "    [D]    \n[N] [C]    \n[Z] [M] [P]\n 1   2   3 \n\nmove 1 from 2 to 1\nmove 3 from 1 to 3\nmove 2 from 2 to 1\nmove 1 from 1 to 2";
        _sub = new Day05(inputText);
    }

    [Fact]
    public async Task TestPart1()
    {
        var result = await _sub.Solve_1();
        Assert.True(result == "CMZ", nameof(result) + $"[{result}] == \"CMZ\"");
        
    }
    
    [Fact]
    public async Task TestPart2()
    {
        var result = await _sub.Solve_2();
        Assert.True(result == "MCD");
    }
}