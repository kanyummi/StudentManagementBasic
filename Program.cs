namespace InheritanceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManage myStudents = new StudentManage();
            int option;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t====================== MENU ====================\n");
                        Console.WriteLine("\t1. Add Students. \n");
                        Console.WriteLine("\t2. Display Students. \n");
                        Console.WriteLine("\t3. Show Highest and Lowest GPA. \n");
                        Console.WriteLine("\t4. Search Student By ID. \n");
                        Console.WriteLine("\t5. Show Students Getting Scholarship.\n");
                        Console.WriteLine("\t6. Exit.\n");
                        Console.WriteLine("\t================================================\n");
                        Console.Write("\tPlease choose an option: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("---------  Add Student's --------- \n");
                                Console.Write("Input number of student: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                myStudents.AddStudent(num);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("---------  Student's Information ---------");
                                myStudents.DisplayStudent();
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("---------  Student's GPA --------- \n");
                                myStudents.ShowAverageGPA();
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("---------  Search Student --------- \n");
                                Console.Write("Enter a Student ID: ");
                                String searchStdId = Console.ReadLine();
                                myStudents.SearchStudentByID(searchStdId);
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("---------  Student's Scholarship --------- \n");
                                myStudents.DisplayScholarshipStudent();
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("---------  Thank you <3 --------- \n");
                                break;
                            default:
                                break;
                        }
                    } while (option != 6);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Please write option");
                }
            }
        }
    }
}