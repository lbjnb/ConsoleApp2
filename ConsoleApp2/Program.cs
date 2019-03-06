using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Hello
    {
        public Hello(String[] args)
        {
            if (args.Length >= 2)
            {
                System.Console.WriteLine("Hello World!{0} is {1}", args[0], args[1]);
            }
            else{
                System.Console.WriteLine("Hello World!");
            }
        }

    }
    public class Method
    {
        static void Main(String[] args)
        {
            Hello hello
                = new Hello(args);

        }
    }
}