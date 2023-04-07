using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    internal class StudentManage
    {
        LinkedList<Student> students;

        public StudentManage() { 
            students = new LinkedList<Student>();
        }

        public void AddStudent(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.Clear();
                Student stu = new Student();
                Console.WriteLine($"\n---------  Add student #{i} --------- \n");
                stu.inputInfo();
                students.AddLast(stu);
            }
        }

        public void DisplayStudent()
        {
            foreach(Student student in students)
            {
                student.showInfo();
            }
        }

        private Student HighestGPA()
        {
            double highestGPA = 0;
            Student current = null;
            foreach (Student student in students)
            {
                if(highestGPA < student.gpa)
                {
                    highestGPA = student.gpa;
                    current = student;
                }
            }
            return current;
        }


        private Student LowestGPA()
        {
            double lowestGPA = 10;
            Student current = null;
            foreach (Student student in students)
            {
                if (lowestGPA > student.gpa)
                {
                    lowestGPA = student.gpa;
                    current = student;
                }
            }
            return current;
        }

        public void ShowAverageGPA()
        {
            Student highestStu = HighestGPA();
            Student lowestStu = LowestGPA();

            if(highestStu != null) {
                Console.WriteLine("Highest Student: " +  highestStu.Name + " | GPA: " + highestStu.gpa);
            } 
            if(lowestStu != null)
            {
                Console.WriteLine("Lowest Student: " + lowestStu.Name + " | GPA: " + lowestStu.gpa);
            }
        }

        public void SearchStudentByID(String id)
        {
            foreach (Student student in students)
            {
                if(student.id.ToLower().Equals(id.ToLower()))
                {
                    student.showInfo();
                } 
            }
        }

        public void DisplayScholarshipStudent()
        {
            foreach(Student student in students)
            {
                if(student.gpa >= 8)
                {
                    student.showInfo();
                }
            }  
        }
    }
}
