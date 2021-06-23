using System;
using System.Collections.Generic;
using System.Linq;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static Double Divide (double x, double y)
        {
            return x / y;
        }
        static int checkfileextension(string filename)
        {
            if (filename.Contains(".cs"))
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {
            double num1 = 10;
            double num2 = 0;
            double solution;
            
                // Test out your Divide() function here!
             
            solution = Divide(num1, num2);
            try
        {
            if (num2 != 0)
            {
                Console.WriteLine(solution);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Value cannot be divided by zero.");
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e);
            
        }
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach(var student in students)
            {
                try
                {
                    if (student.Value.Equals(""))
                    {
                        throw new ArgumentNullException($"{student.Key} did not submit assignment");
                    }
                    else
                    {
                    int score = checkfileextension(student.Value);
                    Console.WriteLine($"{student.Key} : {score}");
                    }
                }
                catch (ArgumentNullException f)
                {
                    Console.WriteLine(f);
                }
            }

            Console.ReadLine();
        }
    }
}
