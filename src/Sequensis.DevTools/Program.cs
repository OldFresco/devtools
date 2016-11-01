using System;

namespace Sequensis.DevTools
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "a":
                        Console.WriteLine("Case 1");
                        break;
                    case "b":
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("Sorry, don't know what you mean");
                        break;
                }
            }
            Console.WriteLine("Please enter a valid argument");
        }
    }
}
