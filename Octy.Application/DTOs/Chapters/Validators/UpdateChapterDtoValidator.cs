using FluentValidation;

namespace Octy.Application.DTOs.Chapters.Validators
{
    public class UpdateChapterDtoValidator : AbstractValidator<UpdateChapterDto>
    {
        public UpdateChapterDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50)
                .WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(p => p.Topics).NotNull();
        }
    }
}