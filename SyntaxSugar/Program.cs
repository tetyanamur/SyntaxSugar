using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ans = 4;
            ;
            var response= (ans < 9)? $"{ans} is less than nine": $"{ans} is greater than or equal to nine";
             
            Console.WriteLine(response);
            
        }
    }
}
