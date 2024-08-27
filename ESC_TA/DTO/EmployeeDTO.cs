namespace ESC_TA.DTO;

public class EmployeeDTO
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public DateOnly HireDate { get; set; }

    public decimal Salary { get; set; }

    public DepartmentDTO? Department { get; set; }

    public JobDTO? Job { get; set; }
}