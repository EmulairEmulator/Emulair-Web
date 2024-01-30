using Emulair.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.BusinessLogic.Implementation.News.Validations
{
    public class AddCommentValidator : AbstractValidator<Comment>
    {
        public AddCommentValidator()
        {
            RuleFor(r => r.Message)
                .NotEmpty().WithMessage("Camp obligatoriu!")
                .Length(5, 500).WithMessage("Comment need to have atleast 5 letters and maximum 500");
        }

    }
}
