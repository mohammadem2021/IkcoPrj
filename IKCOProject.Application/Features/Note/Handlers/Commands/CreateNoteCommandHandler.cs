using IKCOProject.Application.Contracts;
using IKCOProject.Application.Dtos.Note;
using IKCOProject.Application.Dtos.Note.Validator;
using IKCOProject.Application.Features.Note.Requests.Commands;
using IKCOProject.Application.Response;
using Mapster;
using MediatR;

namespace IKCOProject.Application.Features.Note.Handlers.Commands;

public class CreateNoteCommandHandler(INoteRepository repository):IRequestHandler<CreateNoteCommand,BaseCommandResponse>
{
    public async Task<BaseCommandResponse> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResponse = await new CreateNoteDtoValidation()
                .ValidateAsync(request.CreateNoteDto, cancellationToken);
            if (!validationResponse.IsValid)
                return new BaseCommandResponse(validationResponse);
            var result = await repository.Add(request.CreateNoteDto.Adapt<Domain.Entity.Note>());
            return new BaseCommandResponse(result.Id, "ثبت با موفقیت انجام شد.");
        }
        catch
        {
            return new BaseCommandResponse("ثبت با مشکل مواجه شد.");
        }
    }
}