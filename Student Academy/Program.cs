using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string,List<double>>();
            int countStudent = int.Parse(Console.ReadLine());


            for (int i = 0; i < countStudent; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                List<double> grades = new List<double>();
                grades.Add(grade);

                if (!students.ContainsKey(name))
                {
                    students[name]=grades;
                }
                else
                {
                    students[name].AddRange(grades);
                }
            }

            //students = students
                //// .Where(x =>x.Value.Average() >=4,5)
                //  .OrderedByDescending(x => x.Value.Average())
                //  .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(Environment.NewLine,students.Select(x => $"{x.Key} -> {x.Value.Average():f2}")));
        }
    }//nooope!!!
}
