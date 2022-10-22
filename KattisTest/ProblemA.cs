using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KattisTest;

public class ProblemA
{
    public List<string> ValidateData(string path)
    {
        List<string> results = new List<string>();
        var mathInput = File.ReadAllLines(path);
        const int minCalculations = 1;
        const int maxCalculations = 10000;
        if (mathInput.Length <= 1)
        {
            throw new Exception("invalid data");
        }
        int calculations;
        if (!int.TryParse(mathInput.First(), out calculations))
        {
            throw new Exception("invalid data");
        }

        if (calculations < minCalculations || calculations > maxCalculations)
        {
            throw new Exception("invalid data");
        }
        var numbersArray = mathInput.Skip(1).Select(x => ParseToCalculations(x));

        foreach (var number in numbersArray)
        {
            results.Add((Possible(number[0], number[1], number[2]) ? "Possible" : "Impossible"));
        }
        return results;
    }

    private int[] ParseToCalculations(string rawFile)
    {
        var numbers = rawFile.Split(" ");
        var lenght = numbers.Length;
        if (lenght > 3)
        {
            throw new ArgumentException("invalid intevall");
        }
        int a, b, c;
        if (!int.TryParse(numbers[0], out a) || !int.TryParse(numbers[1], out b)
            || !int.TryParse(numbers[2], out c))
        {
            throw new ArgumentException("invalid intevall");
        }
        if (a < 1 || a > 10000) // Todo mer validate
        {
            throw new ArgumentException("invalid intevall");
        }
        return new[] { a, b, c };
    }

    public static bool Possible(int a, int b, int c)
    {
        int results = 0;
        if (a + b == c)
        {
            results++;
        }
        if (a - b == c || b - a == c)
        {
            results++;
        }
        if (a * b == c)
        {
            results++;
        }
        if ((double)a / b == c || (double)b / a == c)
        {
            results++;
        }
        return results == 1 ? true : false;
    }
}

