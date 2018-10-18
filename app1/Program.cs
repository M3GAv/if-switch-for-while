using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();

            ExampleIf();
            ExampleSwitch();
            ExampleFor();
            ExampleWhile();
        }

        static void ExampleIf()
        {
            Console.WriteLine("IF example (check if value = 2)");
            Int32 value = 2;  // <-variable declaration
            if (value == 2)
            {
                Console.WriteLine("value is 2");
            }
            else
            {
                Console.WriteLine("value is different");
            }
            Console.Write(Environment.NewLine); // <- New line
        }

        static void ExampleSwitch()
        {
            Console.WriteLine("SWITCH example");
            Int32 value = 1; // <-variable declaration
            switch (value)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;

                case 2:
                    Console.WriteLine("Value is 2");
                    break;

                default:
                    Console.WriteLine("Value different from 1 and 2");
                    break;
            }
            Console.Write(Environment.NewLine); // <- New line
        }

        static void ExampleFor()
        {
            Console.WriteLine("FOR example (write down numbers 1-4)");
            for (Int32 i = 1; i<5; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write(Environment.NewLine); // <- New line
        }

        static void ExampleWhile()
        {
            Console.WriteLine("WHILE example (write down numbers 1-4)");
            Int32 value = 1;  // <-variable declaration
            while (value<5)
            {
                Console.WriteLine(value);
                value++;
            }
            Console.Write(Environment.NewLine); // <- New line
        }

        static void AppInfo()
        {
            string appName = "C# IF, Switch, For, While Loop Statements";
            string appVersion = "1.0";
            string appAuthor = "Mateusz Celka";
            Console.WriteLine("{0} version: {1} by {2}{3}",appName,appVersion,appAuthor,Environment.NewLine);
        }
    }
}
