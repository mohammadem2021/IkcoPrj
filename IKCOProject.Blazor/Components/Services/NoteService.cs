using IKCOProject.Blazor.Components.Contract;
using IKCOProject.Blazor.Components.Model;
using IKCOProject.Blazor.Components.Model.Common;
using IKCOProject.Blazor.Components.Services.Base;
using Mapster;

namespace IKCOProject.Blazor.Components.Services;

public class NoteService(IClient client): BaseHttpService, INoteService
{
    public async Task<Response<BaseCommandResponseVm>> CreateNoteAsync(CreateNoteVm createNote)
    {
        try
        {
            return new Response<BaseCommandResponseVm>()
            {
                Data = (await client.NotePOSTAsync(createNote
                    .Adapt<CreateNoteDto>())).Adapt<BaseCommandResponseVm>(),
                Success = true,
            };
        }
        catch (ApiException e)
        {
            return ConvertApiExceptions<BaseCommandResponseVm>(e);
        }
    }

    public async Task<Response<BaseCommandResponseVm>> DeleteNoteAsync(int id)
    {
        try
        {
            return new Response<BaseCommandResponseVm>()
            {
                Data = (await client.NoteDELETEAsync(id)).Adapt<BaseCommandResponseVm>(),
                Success = true,
            };
        }
        catch (ApiException e)
        {
            return ConvertApiExceptions<BaseCommandResponseVm>(e);
        }
    }

    public async Task<List<NoteVm>> GetAllNotesAsync()
    {
        return (await client.NoteAllAsync()).Adapt<List<NoteVm>>();
    }
}