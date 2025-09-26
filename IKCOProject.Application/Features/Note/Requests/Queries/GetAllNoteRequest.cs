using IKCOProject.Application.Dtos.Note;
using MediatR;

namespace IKCOProject.Application.Features.Note.Requests.Queries;

public class GetAllNoteRequest:IRequest<List<NoteDto>>
{
    
}