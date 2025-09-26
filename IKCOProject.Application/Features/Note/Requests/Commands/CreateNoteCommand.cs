using IKCOProject.Application.Dtos.Note;
using IKCOProject.Application.Response;
using MediatR;

namespace IKCOProject.Application.Features.Note.Requests.Commands;

public class CreateNoteCommand:IRequest<BaseCommandResponse>
{
    public CreateNoteDto CreateNoteDto { get; set; }
}