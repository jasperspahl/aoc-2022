using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Tests;

public class Day02Test
{
    private readonly Day02 _sub;
    public Day02Test()
    {
        var testInput = "A Y\nB X\nC Z";
        _sub = new Day02(testInput);
    }
    [Fact]
    public async Task TestPart1()
    {
        var result = await _sub.Solve_1();
        Debug.Assert(result != null, nameof(result) + " != null");
        Assert.True(result == "15");
    }

    [Fact]
    public async Task TestPart2()
    {
        var result = await _sub.Solve_2();
        Debug.Assert(result != null, nameof(result) + " != null");
        Assert.True(result == "12");
    }
}