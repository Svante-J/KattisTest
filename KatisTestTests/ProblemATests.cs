using KattisTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KatisTestTests;

public class ProblemATests
{
    [Fact]   
    public void ProblemA_Validation()
    {
              
        var result = ProblemA.Possible(1, 2, 3);

        var expectedOutput = true;

        Assert.Equal(expectedOutput, result);
    }

    [Theory]
    [InlineData(".\\ProblemAInput.txt")]

    public void ProblemA_Sequence(string path)
    {
        var problemA = new ProblemA();
        var result = problemA.ValidateData(path);
       var expected = new List<string> 
        { "Possible",
        "Possible",
        "Impossible",
        "Possible",
        "Possible",
        "Impossible"
        };
        Assert.Equal(expected, result);
    }
}

