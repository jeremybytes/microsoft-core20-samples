using static System.Console;
using Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"The answer is {new Thing().Get(19, 23)}");
        }
    }
}
