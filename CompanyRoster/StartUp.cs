using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CompanyRoster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var entries = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < entries; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                if (input.Length==4)
                {
                    Employee employee = new Employee(name, salary,position, department);
                    employees.Add(employee);

                }
                else if (input.Length==5)
                {
                    try
                    {
                        int param = int.Parse(input[4]);
                        Employee employee = new Employee(name, salary, position, department, param);
                        employees.Add(employee);

                    }
                    catch (Exception e)
                    {
                        Employee employee = new Employee(name, salary, position, department, input[4]);
                        employees.Add(employee);
                    }
                }
                else
                {
                    Employee employee = new Employee(name, salary, position, department, input[4], int.Parse(input[5]));
                    employees.Add(employee);
                }
            }

            var highestDepartment =
                employees.GroupBy(x => x.Department).ToDictionary(x => x.Key, v => v.Select(s => s))
                .OrderByDescending(x=>x.Value.Average(p=>p.Salary)).FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {highestDepartment.Key}");
            foreach (Employee kvp in highestDepartment.Value.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{kvp.Name} {kvp.Salary:f2} {kvp.E_mail} {kvp.Age}");
            }

        }
    }
}
