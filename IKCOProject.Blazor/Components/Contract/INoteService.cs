using IKCOProject.Blazor.Components.Model;
using IKCOProject.Blazor.Components.Model.Common;
using IKCOProject.Blazor.Components.Services.Base;

namespace IKCOProject.Blazor.Components.Contract;

public interface INoteService
{
    Task<Response<BaseCommandResponseVm>> CreateNoteAsync(CreateNoteVm createNote);
    Task<Response<BaseCommandResponseVm>> DeleteNoteAsync(int id);
    Task<List<NoteVm>> GetAllNotesAsync();
}