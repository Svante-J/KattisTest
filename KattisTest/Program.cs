using KattisTest;
using KattisTest.Boiling;
using System.Net.WebSockets;

namespace KattisTest;

class Program
{
   
    static void Main(string[] args)
    {
        var tOne = ProblemA.Possible(1, 2, 3);
        var tTwo = ProblemA.Possible(2, 24, 12);
        var tThree = ProblemA.Possible(5, 3, 1);
        var tFour = ProblemA.Possible(9, 16, 7);
        var tFive = ProblemA.Possible(7, 2, 14);
        var tSix = ProblemA.Possible(12, 4, 2);

        Console.WriteLine(tOne);
        Console.WriteLine(tTwo);
        Console.WriteLine(tThree);
        Console.WriteLine(tFour);
        Console.WriteLine(tFive);
        Console.WriteLine(tSix);
    }
}