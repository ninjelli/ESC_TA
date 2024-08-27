using ESC_TA.Models;

namespace ESC_TA.DTO;

public static class DTOHelperExtensions
{
    public static EmployeeDTO EmployeeToDto(this Employee employee)
    {
        return new EmployeeDTO()
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            HireDate = employee.HireDate,
            Salary = employee.Salary,
            Department = employee.Department?.DepartmentToDto(),
            Job = employee.Job?.JobToDto(),
        };
    }

    public static DepartmentDTO DepartmentToDto(this Department department)
    {
        return new DepartmentDTO()
        {
            DepartmentName = department.DepartmentName,
            Location = department.Location?.LocationToDto(),
        };
    }

    public static JobDTO JobToDto(this Job job)
    {
        return new JobDTO()
        {
            JobTitle = job.JobTitle,
            MaxSalary = job.MaxSalary,
            MinSalary = job.MinSalary
        };
    }

    public static LocationDTO LocationToDto(this Location location) {
        return new LocationDTO()
        {
            StreetAddress = location.StreetAddress,
            StateProvince = location.StateProvince,
            City = location.City,
            Country = location.Country?.CountryToDto(),
            PostalCode = location.PostalCode,
        };
    }

    public static CountryDTO CountryToDto(this Country country)
    {
        return new CountryDTO()
        {
            CountryName = country.CountryName,
            Region = country.Region?.RegionToDto(),
        };
    }

    public static RegionDTO RegionToDto(this Region region)
    {
        return new RegionDTO()
        {
            RegionName = region.RegionName
        };
    }
}
