﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ESC_TA.Models;

public partial class Job
{
    public int JobId { get; set; }

    public string JobTitle { get; set; }

    public decimal? MinSalary { get; set; }

    public decimal? MaxSalary { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}