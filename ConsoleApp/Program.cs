//Those are the namespaces that are (by default) included
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By default Visual Studio creates already a namespace
namespace ConsoleApp
{
    //Remember: Everything (variables, functions) has to be encapsulated
    class Program
    {
        //The entry point is called Main (capital M) and has to be static
        static void Main(string[] args)
        {
            //Writing something to the console is easily possible using the
            //class Console with the static method Write or WriteLine
            Console.WriteLine("Input an integer value for a:");

            //5 here is an integer literal
            int a = 5;

            //A double value is a floating point literal.
            double x = 2.5 + 3.7;
            //A single value is given by a floating point literal with the suffix f.
            float y = 3.1f;

            //Using quotes will automatically generated constant strings
            string someLiteral = "This is a string!";
            string input = Console.ReadLine();

            //int, string, double, float, ... are just keywords - in fact, they are represented
            //by Int32, String, Double, Single - which have static (and non-static) members.
            a = int.Parse(input);//Here we use the static method [int Parse(string)] of Int32.

            //Output of a mod operation - adding string and something (or something and string)
            //will always result in a string. Additionally we have the regular operator ordering
            //which performs a % 10 before the string and a get concatenated.
            Console.WriteLine("a % 10 = " + a % 10);

            //A string is a class, which can be instantiated like this
            string s = "Hi there";
            Console.WriteLine(s);//Hi there
            ChangeString(s);
            Console.WriteLine(s);//Hi there
            ChangeString(ref s);
            Console.WriteLine(s);//s is now a null reference

            //Usually C# forbids us to leave variables uninitialized
            SampleClass sampleClass;
            SampleStruct sampleStruct;

            //However, C# thinks that an out-Function will do the initialization
            HaveALook(out sampleClass);
            HaveALook(out sampleStruct);

            // LOOPS
            Console.Write("Input a test string?");

            input = Console.ReadLine();
            //Let's see if this is empty or not
            if (input == "")
            {
                Console.WriteLine("Empty String!");
            }
            else
            {
                for(int i=0; i<input.Length; i++)
                {
                    switch(input[i])
                    {
                        //A string is a char array and has a Length property
                        //It also can be accessed like a char array, giving
                        //us single chars.
                        case 'a':
                            Console.Write("An a - and not ... ");
                            //This is always required, we cannot just fall through.
                            goto case 'z';
                        case 'z':
                            Console.WriteLine("A z!");
                            break;
                        default:
                            Console.WriteLine("Whatever ...");
                            //This is required even in the last block
                            break;
                    }
                }
            }

            // FOREACH ITERATOR
            //Creating an array is possible by just appending [] to any data type
            int[] myints = new int[4];
            //This is now a fixed array with 4 elements. Arrays in C# are 0-based
            //hence the first element has index 0.
            myints[0] = 2;
            myints[1] = 3;
            myints[2] = 17;
            myints[3] = 24;

            //This foreach construct is new in C# (compared to C++):
            foreach (int myint in myints)
            {
                //Write will not start a new line after the string.
                Console.WriteLine("The element is given by ");
                //WriteLine will do that.
                Console.WriteLine(myint);
            }


        }

        static void ChangeString(string str)
        {
            str = "I changed it!"; 
        }

        static void ChangeString(ref string str)
        {
            str = "I changed it!"; //null (would not print anything
        }

        static void HaveALook(out SampleClass c)
        {
            //Insert a breakpoint here to see the
            //value of c before the assignment:
            //It will be null...
            c = new SampleClass();
        }

        static void HaveALook(out SampleStruct s)
        {
            //Insert a breakpoint here to see the
            //value of s before the assignment:
            //It will NOT be null...
            s = new SampleStruct();
        }

        //In C# you can created nested classes
        class SampleClass
        {

        }

        //A structure always inherits ONLY from object,
        //we cannot specify other classes (more on that later)
        //However, an arbitrary number of interfaces can
        //be implemented (more on that later as well)
        struct SampleStruct
        {

        }

    }
}
