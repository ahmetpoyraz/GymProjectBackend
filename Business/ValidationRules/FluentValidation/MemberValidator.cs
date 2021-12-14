using Entities.Conrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(p=> p.Name).NotEmpty();
            RuleFor(P => P.Name).MinimumLength(3);
        }
    }
}
