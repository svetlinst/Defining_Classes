using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyRoster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string e_mail;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public string E_mail
        {
            get { return this.e_mail; }
            set { this.e_mail = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.age = -1;
            this.e_mail = "n/a";
        }
        public Employee(string name, decimal salary, string position, string department, string e_mail)
            : this(name, salary, position, department)
        {
            this.e_mail = e_mail;
        }
        public Employee(string name, decimal salary, string position, string department,int age)
            :this(name, salary, position,department)
        {
            this.age = age;
        }

        public Employee(string name, decimal salary, string position, string department, int age, string e_mail)
            : this(name, salary, position, department, age)
        {
            this.e_mail = e_mail;
        }

        public Employee(string name, decimal salary, string position, string department, string e_mail, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.age = age;
            this.e_mail = e_mail;
        }

        public override string ToString()
        {
            return $"{this.name} {this.salary} {this.e_mail} {this.age}";
        }
    }
}
