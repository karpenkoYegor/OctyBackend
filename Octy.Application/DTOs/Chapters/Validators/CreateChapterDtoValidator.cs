using FluentValidation;

namespace Octy.Application.DTOs.Chapters.Validators
{
    public class CreateChapterDtoValidator : AbstractValidator<CreateChapterDto>
    {
        public CreateChapterDtoValidator()
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