using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftuniContext context = new SoftuniContext();
            using (context)
            {
                /// Problem 03
                //var problem03employeesFullInformation = context.Employees.Select(
                //    e => e.FirstName + " " + e.LastName + " " + e.MiddleName + " " + e.JobTitle + " " + e.Salary);
                //
                //foreach (var employee in problem03employeesFullInformation)
                //{
                //    Console.WriteLine(employee + "00");
                //}

                /// Problem 04
                //var problem04employeesOver50000 = context.Employees.Where(s => s.Salary > 50000).Select(e => e.FirstName);
                //
                //foreach (var employee in problem04employeesOver50000)
                //{
                //    Console.WriteLine(employee);
                //}

                /// Problem 05
                //var problem05employeesFromSeatle = context.Employees
                //    .Where(employee => employee.Department.Name == "Research and Development")
                //    .OrderBy(salary => salary.Salary)
                //    .ThenByDescending(firstName => firstName.FirstName);
                //
                //foreach (var employee in problem05employeesFromSeatle)
                //{
                //    Console.WriteLine($"{employee.FirstName} {employee.LastName} " + 
                //                      $"from {employee.Department.Name} - ${employee.Salary:F2}");
                //}

                /// Problem 06
                //Address address = new Address()
                //{
                //    AddressText = "Vitoshka 15",
                //    TownID = 4
                //};
                //
                //var nakov = (from Employee in context.Employees
                //             where Employee.LastName == "Nakov"
                //             select Employee).Single();
                //nakov.Address = address;
                //
                //context.SaveChanges();
                //
                //// Output
                //var problem06addressTexts = context.Employees.OrderByDescending(addressId => addressId.AddressID).Take(10);
                //
                //foreach (var addressText in problem06addressTexts)
                //{
                //    Console.WriteLine(addressText.Address.AddressText);
                //}

                /// Problem 07
                //Project project = context.Projects.Find(2);
                //var employeesWithTheProject = context.Employees;
                //
                //foreach (var employee in employeesWithTheProject)
                //{
                //    employee.Projects.Remove(project);
                //}
                //
                //context.SaveChanges();
                //context.Projects.Remove(project);
                //context.SaveChanges();
                //
                //var problem07selectProjects = context.Projects.Select(p => p.Name).Take(10);
                //
                //foreach (var outputProject in problem07selectProjects)
                //{
                //    Console.WriteLine(outputProject);
                //}

                /// Problem 08
                /// TODO!!!!!!
                //var employees = context.Employees.Where(e => e.Projects.Count(project => project.StartDate.Year >= 2001 && project.StartDate.Year <= 2003) > 0).Take(30);
                //
                //foreach (var employee in employees)
                //{
                //    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Manager.FirstName}");
                //
                //    foreach (Project project in employee.Projects)
                //    {
                //        Console.WriteLine($"--{project.Name} {project.StartDate.ToString(CultureInfo.CreateSpecificCulture("en-US"))} {project.EndDate}");
                //    }
                //}

                /// Problem 09

                //var addresses = (from address in context.Addresses
                //                 join employee in context.Employees
                //                 on address.AddressID equals employee.AddressID
                //                 orderby address.Employees.Count descending,
                //                 address.Town.Name ascending
                //                 select address);
                //
                //foreach (var address in addresses)
                //{
                //    Console.WriteLine(address.AddressText + ", " + address.Town.Name + " - " + address.Employees.Count + " employees");
                //}
            }
        }
    }
}