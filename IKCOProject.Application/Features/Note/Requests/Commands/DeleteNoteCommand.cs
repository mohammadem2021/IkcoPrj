using IKCOProject.Application.Response;
using MediatR;

namespace IKCOProject.Application.Features.Note.Requests.Commands;

public class DeleteNoteCommand:IRequest<BaseCommandResponse>
{
    public int Id { get; set; }
}