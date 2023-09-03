using FluentValidation;
using Pustok.Database.Models;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Category Name is required.")
            .MaximumLength(255).WithMessage("Category Name cannot exceed 255 characters.");
    }
}
