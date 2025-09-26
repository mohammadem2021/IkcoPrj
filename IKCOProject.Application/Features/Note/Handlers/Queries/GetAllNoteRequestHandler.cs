using IKCOProject.Application.Contracts;
using IKCOProject.Application.Dtos.Note;
using IKCOProject.Application.Features.Note.Requests.Queries;
using Mapster;
using MediatR;

namespace IKCOProject.Application.Features.Note.Handlers.Queries;

public class GetAllNoteRequestHandler(INoteRepository repository):IRequestHandler<GetAllNoteRequest, List<NoteDto>>
{
    public async Task<List<NoteDto>> Handle(GetAllNoteRequest request, CancellationToken cancellationToken)
    {
        return (await repository.GetAll()).Adapt<List<NoteDto>>();
    }
}