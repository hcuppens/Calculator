using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using Calculator;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression e = new Expression(args[1]);


            System.Console.WriteLine(e.Evaluate());
        }
    }
}
