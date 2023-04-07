using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    internal class Student : Person
    {
        public string id;
        public double gpa;
        public string email;

        public Student()
        {

        }
        public Student(string name, string gender, string birthday, 
            string address, string id, float gpa, string email) : base(name, gender, birthday, address)
        {
            this.id = id;
            this.gpa = gpa;
            this.email = email;
        }
        public override void inputInfo()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input ID: ");
                    id = Console.ReadLine();
                    base.inputInfo();
                    Console.Write("Input GPA: ");
                    gpa = Convert.ToDouble(Console.ReadLine());
                    if (gpa < 0 || gpa > 10)
                    {
                        throw new Exception();
                    }
                    Console.Write("Input Email: ");
                    email = Console.ReadLine();
                    if (!email.Contains('@'))
                    {
                        throw new Exception();
                    }
                    break;
                } catch (Exception e)
                {
                    Console.WriteLine("Invalid input! please try again");
                }
            }
        }

        public override void showInfo()
        {
            Console.Write("\n\n | ID: " + id + " | ");
            base.showInfo();
            Console.Write(" | GPA: " + gpa);
            Console.Write(" | Email: " + email);
        }

        public void IsScholarship()
        {
            if(this.gpa >= 8.0)
            {
                Console.WriteLine($"Student #{id} has got a scholarship!");
            } else
            {
                Console.WriteLine($"Student #{id} is not good enough to get a scholarship!");
            }
        }
    }
}
