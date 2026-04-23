using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public record EmployeeDto(
    int Id,
    string FirstName,
    string LastName,
    string Email,
    string DepartmentName,
    decimal Salary
    );
}
