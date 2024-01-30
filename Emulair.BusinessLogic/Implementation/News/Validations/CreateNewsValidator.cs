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
    public class CreateNewsValidator : AbstractValidator<NewsModel>
    {
        private UnitOfWork _unitOfWork;
        public CreateNewsValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(r => r.Title)
                .NotEmpty().WithMessage("Camp obligatoriu!")
                .Must(NotAlreadyExist).WithMessage("There is already an existing news with this title!")
                .Length(3, 100).WithMessage("Title must have atleast 3 letters and 100 maximum!");
            RuleFor(r => r.Description)
                .NotEmpty().WithMessage("Camp obligatoriu!")
                .Length(3, 5000).WithMessage("Description must have atleast 3 letters and maximum 5000");

        }
        public bool NotAlreadyExist(string Title)
        {
            var mail = _unitOfWork.News.Where(u => u.Title == Title).FirstOrDefault();
            if (mail == null)
                return true;
            return false;
        }
    }
}
