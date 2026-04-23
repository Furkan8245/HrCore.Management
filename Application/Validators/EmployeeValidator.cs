using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class EmployeeValidator:AbstractValidator<CreateEmployeeRequest>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Salary).GreaterThan(0).WithMessage("Maaş sıfırdan büyük olmalıdır.");
            RuleFor(x => x.BirthDate).LessThan(DateTime.Now.AddYears(-18))
                .WithMessage("Çalışan 18 yaşından küçük olamaz.");
        }
    }
}
