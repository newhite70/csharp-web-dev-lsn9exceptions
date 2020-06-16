



using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;

namespace csharp_web_dev_lsn9exceptions
{

    class Program

    {

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("y", "Never divide by Zero! You should know that!!");
            }
            else
            {
                return x / y;
            }
        }

        public static int CheckFileExtension(string fileName)
        {
            if (fileName == null || fileName == "")
            {
                throw new ArgumentOutOfRangeException(paramName: fileName, message: "Please submit somework");
                //return 0;
            }
            else
            {
                if (fileName.EndsWith(".cs"))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }



        static void Main(string[] args)
        {
            double x = 10.0;
            double y = 0.0;
            try
            {
                Divide(x, y);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> entry in students)
            {
                try
                {
                    Console.WriteLine(entry.Key);
                    CheckFileExtension(entry.Value);
                }
                catch(ArgumentNullException n)
                {
                    Console.WriteLine(n.Message);
                }
            }
        }
    }
}