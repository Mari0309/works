using System;
using System.Text.RegularExpressions;
namespace ConsoleApplication

{
    class Program
    {
        static int PlaceCount(int num) => Math.Abs(num).ToString().Length;
        static void Main(string[] args)
        {
            Console.WriteLine(PlaceCount(2234)); 
            Console.WriteLine(PlaceCount(223)); 
            Console.WriteLine(PlaceCount(-100)); 
            Console.WriteLine(PlaceCount(123321123)); 
            Console.WriteLine(PlaceCount(22341)); 
        }
    }
}