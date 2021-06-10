using System.ComponentModel.DataAnnotations;
namespace Lab5.Validation
{
    public class AnswerAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object answer,ValidationContext context)
        {
            var correct = context.ObjectType.GetMethod("PresetAction").Invoke(context.ObjectInstance,null);
            if (answer.ToString().Length > 5)
            {
                
                return new ValidationResult("Answer value is too big");
              
            }
            if (!object.Equals(answer, correct))
            {
                return new ValidationResult(this.FormatErrorMessage("Incorrect"));
                
            }
            
            return ValidationResult.Success;
        }
    }
}
