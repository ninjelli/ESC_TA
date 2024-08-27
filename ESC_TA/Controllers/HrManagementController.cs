using Microsoft.AspNetCore.Mvc;

namespace ESC_TA.Controllers;

[ApiController]
[Route("[controller]")]
public class HrManagementController : ControllerBase
{
    public HrManagementController()
    {

    }

    [HttpGet("employees")]
    public IActionResult GetEmployeeData()
    {
        try
        {
            return Ok(null);
        }
        catch (Exception exception)
        { 
            return BadRequest(exception.Message);
        }
    }

    /// <summary>
    /// Verb used in restful name dileberately to meet requirements. Suggest refactor to return all employees if no query params given and combine with GetEmployeeData function
    /// </summary>
    /// <param name="id"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="email"></param>
    /// <param name="departmentName"></param>
    /// <param name="country"></param>
    /// <param name="regionName"></param>
    /// <returns></returns>
    [HttpGet("employees/search")]
    public IActionResult EmployeeSearch(int? id, string? firstName, string? lastName, string? email, string? departmentName, string? country, string? regionName)
    {
        try
        {
            return Ok(null);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }
}
