using FluentValidation;

namespace IKCOProject.Application.Dtos.Note.Validator;

public class CreateNoteDtoValidation:AbstractValidator<CreateNoteDto>
{
    public CreateNoteDtoValidation()
    {
        RuleFor(r => r.Title)
            .NotEmpty().WithMessage("موضوع یاداشت الزامی می باشد.")
            .MaximumLength(250)
            .WithMessage("تعداد کارکتر ها از 250 عدد بیشتر می باشد.");
    }
}