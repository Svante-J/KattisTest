using KattisTest.Boiling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KattisTest;

public class ProblemB
{
    public string IntersectionCheck(string path)
    {
        var cookingLogg = File.ReadAllLines(path);
        const int minCookingAttempts = 1;
        const int maxCookingAttempts = 1000;

        if (cookingLogg.Length <= 0)
        {
            throw new Exception("invalid data");
        }

        int cookingAtempts;
        if (!int.TryParse(cookingLogg.First(), out cookingAtempts))
        {
            throw new Exception("invalid data");
        }

        if (cookingAtempts < minCookingAttempts || cookingAtempts > maxCookingAttempts)
        {
            throw new Exception("invalid data");
        }

        var list = cookingLogg.Skip(1).Select(x => ParseToInterval(x));
        return RangeGap(list) ? "edward is right" : "gunilla has a point";
    }

    private bool RangeGap(IEnumerable<Interval> intervals)
    {
        var maxStart = intervals.Max(i => i.StartTime);
        var minEnd = intervals.Min(i => i.EndTime);

        return minEnd < maxStart;
    }

    private Interval ParseToInterval(string x)
    {
        var numbers = x.Split(" ");
        var lenhgt = numbers.Length;
        if (lenhgt > 2)
        {
            throw new ArgumentException("invalid intevall");
        }

        int startTime, endTime;
        if (!int.TryParse(numbers[0], out startTime) || !int.TryParse(numbers[1], out endTime))
        {
            throw new ArgumentException("invalid intevall");
        }
        if (startTime > endTime && startTime < 0 && endTime > 1000)
        {
            throw new ArgumentException("invalid intevall");
        }
        return new Interval
        {
            StartTime = startTime,
            EndTime = endTime
        };
    }
}

