using FluentValidation.Results;

namespace Emulair.Common.Exceptions
{
    public class ValidationErrorException : Exception
    {
        public readonly ValidationResult ValidationResult;
        public readonly object Model;

        public ValidationErrorException(ValidationResult result, object model)
        {
            ValidationResult = result;
            Model = model;
        }
    }
}
