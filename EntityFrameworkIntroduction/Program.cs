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
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-US");

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
                //// There is an issue with grouping! TODO.
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

                /// Problem 10
                //var employeeWithId147 = context.Employees.Find(147);
                //var projectsOfEmployeeWithId147 = employeeWithId147.Projects.OrderBy(n => n.Name).ToArray();
                //
                //Console.WriteLine($"{employeeWithId147.FirstName} {employeeWithId147.LastName} {employeeWithId147.JobTitle}");
                //foreach (var project in projectsOfEmployeeWithId147)
                //{
                //    Console.WriteLine($"{project.Name}");
                //}

                /// Problem 11
                //var departments = context.Departments
                //    .OrderBy(c => c.Employees.Count)
                //    .Where(ec => ec.Employees.Count > 5);
                //
                //foreach (var department in departments)
                //{
                //    Employee manager = (from Employee in context.Employees
                //                   where Employee.EmployeeID == department.ManagerID
                //                   select Employee).Single();
                //    Console.WriteLine($"{department.Name} {manager.FirstName}");
                //
                //    var employeesInDepartment = department.Employees;
                //
                //    // Not outputting the same order, why? I don't know.
                //    //var employeesInDepartment = context.Employees
                //    //    .Where(e => e.Department.Name == department.Name);
                //
                //    foreach (var employee in employeesInDepartment)
                //    {
                //        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
                //    }
                //}

                /// Problems 12 to 14 TODO

                /// Problem 15
                //var latestProjects = context.Projects
                //    .OrderByDescending(sd => sd.StartDate)
                //    .Take(10);
                //
                //// TODO: Lexicographical sort algorithm for latestProjects.Name
                //
                //foreach (var project in latestProjects)
                //{
                //    Console.WriteLine($"{project.Name} {project.Description} {project.StartDate} {project.EndDate}");
                //}

                /// Problem 16
                //var employeesToRaiseSalary = context.Employees
                //    .Where(e => e.Department.Name == "Engineering" ||
                //                e.Department.Name == "Tool Design" ||
                //                e.Department.Name == "Marketing" ||
                //                e.Department.Name == "Information Services");
                //
                //foreach (var employee in employeesToRaiseSalary)
                //{
                //    employee.Salary *= 1.12m;
                //    Console.WriteLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:F6})");
                //}
                //
                //context.SaveChanges();

                /// Problem 17
                //string townToDelete = Console.ReadLine();
                //
                //Town town = (from Town in context.Towns
                //             where Town.Name == townToDelete
                //             select Town).Single();
                //var addressesWithTheTown = context.Addresses.Where(a => a.Town.Name == townToDelete);
                //int removedAddresses = 0;
                //
                //foreach (var address in addressesWithTheTown)
                //{
                //    var employeesWithTheAddress = (from Employee in context.Employees
                //                                       where Employee.AddressID == address.AddressID
                //                                       select Employee);
                //    foreach (var employee in employeesWithTheAddress)
                //    {
                //        employee.AddressID = null;
                //    }
                //    context.Addresses.Remove(address);
                //    removedAddresses++;
                //}
                //
                //context.SaveChanges();
                //context.Towns.Remove(town);
                //context.SaveChanges();
                //
                //if (removedAddresses != 1)
                //{
                //    Console.WriteLine($"{removedAddresses} address in {townToDelete} were deleted");
                //}
                //else
                //{
                //    Console.WriteLine($"{removedAddresses} addresses in {townToDelete} were deleted");
                //}

                /// Problem 18
                //var employeesNamesStartingWithSa = context.Employees
                //    .Where(a => a.FirstName.StartsWith("Sa"));
                //
                //foreach (var employee in employeesNamesStartingWithSa)
                //{
                //    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary})");
                //}
            }
        }
    }
}