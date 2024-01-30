using Emulair.BusinessLogic.Implementation.News.Models;
using Emulair.DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.BusinessLogic.Implementation.News.Validations
{
    public class EditNewsValidator : AbstractValidator<NewsModel>
    {
        private UnitOfWork _unitOfWork;
        public EditNewsValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(r => r.Title)
                .NotEmpty().WithMessage("Camp obligatoriu!")
                .Length(3, 100).WithMessage("Title must have atleast 3 letters and 100 maximum!");
            RuleFor(r => r.Description)
                .NotEmpty().WithMessage("Camp obligatoriu!")
                .Length(3, 5000).WithMessage("Description must have atleast 3 letters and maximum 5000");

        }
    }
}
