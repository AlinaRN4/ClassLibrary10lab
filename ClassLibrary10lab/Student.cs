using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10lab
{
    public class Student:IInit, IComparable<Student>
    {
        private string name;
        private int age;
        private double gpa;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else
                    throw new ArgumentNullException("Name cannot be null.");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120) // Assuming age is between 0 and 120
                    age = value;
                else
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
            }
        }

        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4.0) // Assuming GPA is between 0 and 4.0
                    gpa = value;
                else
                    throw new ArgumentOutOfRangeException("GPA must be between 0 and 4.0.");
            }
        }

        public Student()
        {
            // Default constructor
        }

        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }

        public Student(Student student)
        {
            Name = student.Name;
            Age = student.Age;
            GPA = student.GPA;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, GPA: {GPA}");
        }

        public void Init()
        {
            Console.Write("Enter student's name: ");
            Name = Console.ReadLine();

            Console.Write("Enter student's age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter student's GPA: ");
            GPA = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Имя: " + Name + " Возраст: " + Age + " GPA: " + GPA;
        }


        public void RandomInit()
        {
            Random random = new Random();

            Name = "Student" + random.Next(1, 100);
            Age = random.Next(18, 25); // Assuming student age is between 18 and 24
            GPA = Math.Round(random.NextDouble() * 4, 2); // Random GPA between 0 and 4.0
        }
        public int CompareTo(Student other)
        {
            return this.gpa.CompareTo(other.gpa);
        }
    }
}
