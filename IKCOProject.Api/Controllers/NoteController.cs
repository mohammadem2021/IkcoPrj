using IKCOProject.Application.Dtos.Note;
using IKCOProject.Application.Features.Note.Requests.Commands;
using IKCOProject.Application.Features.Note.Requests.Queries;
using IKCOProject.Application.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKCOProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<NoteDto>>> Notes()
        {
            return await mediator.Send(new GetAllNoteRequest());
        }
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Notes(CreateNoteDto createNoteDto)
        {
            return await mediator.Send(new CreateNoteCommand(){CreateNoteDto = createNoteDto});
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<BaseCommandResponse>> Notes(int id)
        {
            return await mediator.Send(new DeleteNoteCommand() { Id = id });
        }
    }
}
