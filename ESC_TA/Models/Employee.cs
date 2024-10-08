﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ESC_TA.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public DateOnly HireDate { get; set; }

    public int JobId { get; set; }

    public decimal Salary { get; set; }

    public int? ManagerId { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department Department { get; set; }

    public virtual ICollection<Dependent> Dependents { get; set; } = new List<Dependent>();

    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    public virtual Job Job { get; set; }

    public virtual Employee Manager { get; set; }
}