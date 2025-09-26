using BlazorBootstrap;
using IKCOProject.Blazor.Components.Contract;
using IKCOProject.Blazor.Components.Model;
using IKCOProject.Blazor.Components.Model.Common;
using IKCOProject.Blazor.Components.Services.Base;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;

namespace IKCOProject.Blazor.Components.Pages
{
    public partial class Note:ComponentBase
    {
        private Grid<NoteVm> gride = default!;
        [Inject] INoteService NoteService { get; set; }
        private List<NoteVm> Notes { get; set; } = new();
        private CreateNoteVm CreateNoteVm { get; set; }=new() ;
        public Modal CreateNoteModal;
        public BaseCommandResponseVm ResponseVm { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {
            Notes =await GetNotes();
            await base.OnInitializedAsync(); }
  

        private  Task<List<NoteVm>> GetNotes()
        {
            return  NoteService.GetAllNotesAsync();
        }

        private async Task CreateNote(EditContext obj)
        {
        
            var response = await NoteService.CreateNoteAsync(CreateNoteVm);
            if (response.Success)
            {
                if (response.Data.Success == true)
                {
                    Notes = await GetNotes();
                    await CreateNoteModal.HideAsync();
                    await gride.RefreshDataAsync();
                    ResponseVm = response.Data;
                    CreateNoteVm = new();

                }
                else
                {
                    ResponseVm = response.Data;
                }
            }
        }

        private async Task RemoveNote(int id)
        {
            var response = await NoteService.DeleteNoteAsync(id);
            if (response.Success)
            {
                if (response.Data.Success == true)
                {
                    Notes = await GetNotes();
                    await gride.RefreshDataAsync();
                    ResponseVm = response.Data;

                }
                else
                {
                    ResponseVm = response.Data;
                }
            }
        }
    }
}
