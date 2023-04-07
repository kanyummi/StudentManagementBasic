using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    internal class Person
    {
        protected string name;
        protected string gender;
        protected string birthday;
        protected string address;

        public Person() { }

        public Person(string name, string gender, string birthday, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Birthday 
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public virtual void inputInfo()
        {
            Console.Write("Input name: ");
            name = Console.ReadLine();
            Console.Write("Input gender: ");
            gender = Console.ReadLine();
            Console.Write("Input birthday: ");
            birthday = Console.ReadLine();
            Console.Write("Input address: ");
            address = Console.ReadLine();
        }
        public virtual void showInfo()
        {
            Console.WriteLine($"Name: {name} | Gender: {gender} | Birthday: {birthday} | Address: {address}");
        }
    }
}
