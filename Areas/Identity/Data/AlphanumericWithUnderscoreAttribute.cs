using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Sushil_AssignmentTest.Areas.Identity.Data
{
    public class AlphanumericWithUnderscoreAttribute: ValidationAttribute
    {
        private static readonly Regex _regex = new Regex("^[a-zA-Z0-9_]*$", RegexOptions.Compiled);

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var stringValue = value as string;

            if (stringValue == null)
            {
                return ValidationResult.Success; // or new ValidationResult("Value cannot be null");
            }

            if (_regex.IsMatch(stringValue))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The field can only contain alphanumeric characters and underscores.");
        }
    }
}
