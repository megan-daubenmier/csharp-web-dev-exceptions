using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("The denominator is 0.");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            int numPoints;
            if (fileName == "" || fileName == null)
            {
                throw new ArgumentNullException("Please enter a non-null file name.");
            }
            else if (fileName.Substring(fileName.Length - 3) != ".cs")
            {
                numPoints = 0;
            }
            else
            {
                numPoints = 1;
            }

            return numPoints;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            double divisionResult = 0;
            try
            {
                divisionResult = Divide(1, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Please enter a non-zero denominator.");
            }

            //Console.WriteLine(divisionResult);

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key + ": " + CheckFileExtension(student.Value));
                }
                catch (ArgumentNullException n)
                {
                    Console.WriteLine("Please provide a non-null file name.");
                }
            }
        }
    }
}
