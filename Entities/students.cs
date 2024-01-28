using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Entities
{
    public class Student
    {
        public int Number { get; set; }
        public int Phonenumber { get; set; }
        public string? Gender { get; set; }
        public string? Field { get; set; }
        public void Read()
        {
            Console.Write("Student number:");
            Number = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Student phonenumber:");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Student gender:");
            Gender = Console.ReadLine();
            Console.Write("Student field:");
            Field = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"student number:{Number}-student phonenumber:{Phonenumber}-student gender:{Gender}-student field:{Field}";
        }
    }
}