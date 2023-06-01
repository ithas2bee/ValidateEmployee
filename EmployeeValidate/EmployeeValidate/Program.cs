using System;

public class Employee
{
    public int EmployeeId { get; set; }
    private string Address { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }

    public Employee(int employeeId, string address, string firstName, string lastName, bool isActive)
    {
        EmployeeId = employeeId;
        Address = address;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
    }
}

public class Manager : Employee
{
    private decimal Salary { get; set; }
    public string JobTitle { get; set; }

    public Manager(int employeeId, string address, string firstName, string lastName, bool isActive, string jobTitle, decimal salary)
        : base(employeeId, address, firstName, lastName, isActive)
    {
        JobTitle = jobTitle;
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }
}

public class Technician : Employee
{
    private decimal Salary { get; set; }
    public string JobTitle { get; set; }

    public Technician(int employeeId, string address, string firstName, string lastName, bool isActive, string jobTitle, decimal salary)
        : base(employeeId, address, firstName, lastName, isActive)
    {
        JobTitle = jobTitle;
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }
}

public class Sales : Employee
{
    private decimal Salary { get; set; }
    public string JobTitle { get; set; }

    public Sales(int employeeId, string address, string firstName, string lastName, bool isActive, string jobTitle, decimal salary)
        : base(employeeId, address, firstName, lastName, isActive)
    {
        JobTitle = jobTitle;
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }
}

public class Care : Employee
{
    private decimal Salary { get; set; }
    public string JobTitle { get; set; }

    public Care(int employeeId, string address, string firstName, string lastName, bool isActive, string jobTitle, decimal salary)
        : base(employeeId, address, firstName, lastName, isActive)
    {
        JobTitle = jobTitle;
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }
}

public class Program
{
    public static void Main()
    {
        // Example usage
        var manager = new Manager(1, "123 Main St", "John", "Doe", true, "Manager", 5000);
        var technician = new Technician(2, "456 Elm St", "Jane", "Smith", true, "Technician", 3000);

        Console.WriteLine($"Manager: {manager.FirstName} {manager.LastName}, Salary: {manager.GetSalary()}");
        Console.WriteLine($"Technician: {technician.FirstName} {technician.LastName}, Salary: {technician.GetSalary()}");
    }
}
