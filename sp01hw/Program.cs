using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sp01hw
{
    internal class Program
    {
        static class DLLexample
        {
            [DllImport("User32.dll")]
            public static extern int GetSystemMetrics(int inta);
            public const int SM_CXSCREEN = 0;
            public const int SM_CYSCREEN = 1;
        }
        static void Main(string[] args)
        {
            int screenWidth = DLLexample.GetSystemMetrics(DLLexample.SM_CXSCREEN);
            int screenHeight = DLLexample.GetSystemMetrics(DLLexample.SM_CYSCREEN);
            Console.WriteLine("Разрешение {0}x{1}", screenWidth, screenHeight);
            Console.Write("Enter your PPI -> ");
            double PPI = double.Parse(Console.ReadLine());
            Console.WriteLine($"You have : {Math.Round((double)Math.Sqrt(Math.Pow(screenHeight, 2) + Math.Pow(screenWidth, 2))/PPI,2)} inches.");
            Console.ReadKey();
        }
    }
}
