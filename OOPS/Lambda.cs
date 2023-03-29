using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    delegate void Sum(int a, int b);
    internal class Lambda
    {
         void Main(string[] args)
        {
            Sum add = (int a, int b) => { Console.WriteLine(a + b); };
            add += (int a, int b) => { Console.WriteLine(a - b); };
            add.Invoke(3, 4);

            List<int> list = new() { 1, 5, 10, 12, 15, 18, 20 };
            List<int> divisibleBy5 = list.FindAll(x => x % 5 == 0);
            foreach (int x in divisibleBy5) { Console.WriteLine(x); }

            List<string> strList = new() { "ananth", "sekar", "sundar", "dumb" };
            List<string> filteredList = strList.FindAll(x => x.Contains("d"));
            foreach (string str in filteredList)
            {
                Console.WriteLine(str);
            }
            List<Student> studentList = new()
            {
                new Student() { Age = 20, Dept = "CSE", Name= "Ananth"  },
                new Student() { Age = 17, Dept = "CSE", Name = "Ananth1" }
            };

            int i = 1;

            studentList.ForEach(student =>
            {
                student.Id = i++;
            });

            studentList.Sort((s1, s2) => s2.Id - s1.Id);

            studentList.Sort((student1, student2) => -student1.Age);

            foreach (Student student in studentList)
            {

                Console.WriteLine(student.Id);
            }

            Lambda.PrintHello("Ananth");

        }

        public static void PrintHello(string message)
        {
            var result = (string name) => { Console.WriteLine($"Hi {name}"); };
            result.Invoke(message);
        }
        internal class Student
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }

            public int Id { get; set; }
        }
    }
}
