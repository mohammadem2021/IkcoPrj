using IKCOProject.Application.Contracts;
using IKCOProject.Application.Features.Note.Requests.Commands;
using IKCOProject.Application.Response;
using MediatR;

namespace IKCOProject.Application.Features.Note.Handlers.Commands;

public class DeleteNoteCommandHandler(INoteRepository repository) :IRequestHandler<DeleteNoteCommand,BaseCommandResponse>
{
    public async Task<BaseCommandResponse> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
    {
        var result =await repository.Get(request.Id);
        if (result!=null)
        {
            await repository.Remove(result);
            return new BaseCommandResponse(result.Id, "حدف با موفقیت انجام شد.");
        }
        else
        {
            return new BaseCommandResponse("حدف با مشکل مواجه شد دوباره سعی کنید.");
        }
    }
}