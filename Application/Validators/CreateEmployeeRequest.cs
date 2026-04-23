using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public record CreateEmployeeRequest(
        string FirstName,
        string LastName,
        string Email,
        string Phone,
        decimal Salary,
        DateTime BirthDate,
        int DepartmentId
        );
}
