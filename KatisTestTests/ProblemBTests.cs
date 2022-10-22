using KattisTest;
using KattisTest.Boiling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace KatisTestTests;

public class ProblemBTests
{   
    [Theory]
    [InlineData(".\\exempel1.txt", "gunilla has a point")]
    [InlineData(".\\exempel2.txt", "edward is right")]    
    public void ProblemB_Validation(string path, string expectedOutput)
    {
        var problemB = new ProblemB();
        var result = problemB.IntersectionCheck(path);

        Assert.Equal(expectedOutput, result);
    }

    [Theory]   
    [InlineData(".\\error.txt")]
    public void ProblemB_InvalidData(string path)
    {
        Assert.Throws<Exception>(() => new ProblemB().IntersectionCheck(path));
    }
}

