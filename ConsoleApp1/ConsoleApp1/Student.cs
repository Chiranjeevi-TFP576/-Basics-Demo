using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        string name;
        int rank;
        int id;
        public Student(string name, int rank, int id)//constructor
        {
            this.name = name;
            this.rank = rank;
            this.id = id;
        }
        public Student(Student a)
        {
            name = a.name;
            rank = a.rank;
            id = a.id;
        }

        public void Display()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Rank :" + rank);
            Console.WriteLine("Id :" + id);

        }
    }
}
