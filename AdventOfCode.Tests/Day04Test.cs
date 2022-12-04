using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Tests;

public class Day04Test
{
    private readonly Day04 _sub;

    public Day04Test()
    {
        var testInput = "2-4,6-8\n2-3,4-5\n5-7,7-9\n2-8,3-7\n6-6,4-6\n2-6,4-8";
        _sub = new Day04(testInput);
    }

    [Fact]
    public async Task TestPart1()
    {
        var result = await _sub.Solve_1();
        Debug.Assert(result != null, nameof(result) + " != null");
        Assert.True(result == "2");
    }
    [Fact]
    public async Task TestPart2()
    {
        var result = await _sub.Solve_2();
        Debug.Assert(result != null, nameof(result) + " != null");
        Assert.True(result == "4", $"{result} == \"4\"");
    }
}