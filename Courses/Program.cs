using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> courses = new Dictionary<string,string>();

            string command = "";
            while (command!="end")
            {
                string[] input = Console.ReadLine().Split(":");
                command = input[0];
                string student = input[1];
                if (command=="end")
                {
                    break;
                }

                if (!courses.ContainsKey(command))
                {
                    courses.Add(command,student);
                }
                else
                {
                    courses[command] += student;
                }
            }
            foreach (var item in courses)
            {
               //????
            }
        }
    }
}
