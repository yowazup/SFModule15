﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.WebSockets;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var result = new List<string>();

            foreach (var c in classes)
            {
                foreach (var student in c.Students)
                    result.Add(student);
            }
            return result.ToArray();
        }
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }

}