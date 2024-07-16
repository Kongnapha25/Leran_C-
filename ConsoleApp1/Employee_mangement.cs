// using System;
// using System.Collections.Generic;

// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Position { get; set; }
//     public double Salary { get; set; }

//     public Employee(int id, string name, string position, double salary)
//     {
//         Id = id;
//         Name = name;
//         Position = position;
//         Salary = salary;
//     }
// }

// class EmployeeManagementSystem
// {
//     private List<Employee> employees = new List<Employee>();

//     public void AddEmployee(int id, string name, string position, double salary)
//     {
//         employees.Add(new Employee(id, name, position, salary));
//         Console.WriteLine("Employee added successfully.");
//     }

//     public void RemoveEmployee(int id)
//     {
//         employees.RemoveAll(e => e.Id == id);
//         Console.WriteLine("Employee removed successfully.");
//     }

//     public void UpdateEmployee(int id, string name, string position, double salary)
//     {
//         var employee = employees.Find(e => e.Id == id);
//         if (employee != null)
//         {
//             employee.Name = name;
//             employee.Position = position;
//             employee.Salary = salary;
//             Console.WriteLine("Employee updated successfully.");
//         }
//         else
//         {
//             Console.WriteLine("Employee not found.");
//         }
//     }

//     public void DisplayAllEmployees()
//     {
//         Console.WriteLine("Employee Records:");
//         foreach (var employee in employees)
//         {
//             Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         EmployeeManagementSystem ems = new EmployeeManagementSystem();

//         ems.AddEmployee(1, "บอลค้าบ", "Manager", 50000);
//         ems.AddEmployee(2, "พี่โอ๊ต", "Developer", 40000);

//         ems.DisplayAllEmployees();

//         ems.UpdateEmployee(2, "ลูกพี่หลุยส์", "Senior Developer", 45000);

//         ems.DisplayAllEmployees();

//         ems.RemoveEmployee(1);

//         ems.DisplayAllEmployees();
//     }
// }
