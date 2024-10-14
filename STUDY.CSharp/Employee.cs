using System;

namespace STUDY.CSharp;

public enum Role
{
    Admin = 1,
    Accountant = 2,
    Stock = 4,
    Reception = 8
}
public struct Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public Role EmployeeRole { get; private set; }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary}, Role: {EmployeeRole}");
    }

    public void AssignRole(Role role)
    {
        EmployeeRole = role;
    }

    public bool HasRole(Role role)
    {
        return EmployeeRole == role;
    }
}