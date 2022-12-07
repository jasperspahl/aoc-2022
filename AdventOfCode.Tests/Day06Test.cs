using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Tests;

public class Day06Test
{
    private Day06 _sub;

    public Day06Test()
    {
    }

    [Fact]
    public async Task TestPart1()
    {
        _sub = new Day06("bvwbjplbgvbhsrlpgdmjqwftvncz");
        var result = await _sub.Solve_1();
        Assert.True(result == "5", nameof(result) + $"[{result}] == \"5\"");
        
    }
    
    // [Fact]
    // public async Task TestPart2()
    // {
    //     var result = await _sub.Solve_2();
    //     Assert.True(result == "MCD");
    // }
}