using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace To_do.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class NoteController(INoteService noteService) : ControllerBase
    {
        [HttpPost("notes/add")]
        public async Task<IActionResult> AddNoteAsync([FromQuery] string title, string description, DateTime deadline)
        {
            await noteService.CreateAsync(title, description, deadline);
            return Created();
        }

        [HttpGet("notes/get/all")]
        public async Task<IActionResult> GetAllNotesAsync()
        {
            var notes = await noteService.GetAllAsync();
            return Ok(notes);
        }

        [HttpGet("notes/get/active")]
        public async Task<IActionResult> GetActiveNotesAsync()
        {
            var notes = await noteService.GetActiveAsync();
            return Ok(notes);
        }

        [HttpGet("notes/get/completed")]
        public async Task<IActionResult> GetCompletedNotesAsync()
        {
            var notes = await noteService.GetCompletedAsync();
            return Ok(notes);
        }

        [HttpGet("notes/get/{id:int}")]
        public async Task<IActionResult> GetNoteByIdAsync([FromRoute]int id)
        {
            var note = await noteService.GetByIdAsync(id);
            return Ok(note);
        }

        [HttpPut("notes/edit/{id:int}")]
        public async Task<IActionResult> UpdateNoteAsync([FromRoute]int id, string newTitle, string newDescription, DateTime newDeadline)
        {
            await noteService.UpdateAsync(id, newTitle, newDescription, newDeadline);
            return Ok();
        }

        [HttpPatch("notes/{id:int}/complete")]
        public async Task<IActionResult> MarkAsCompletedAsync([FromRoute]int id)
        {
            await noteService.MarkAsCompletedAsync(id);
            return Ok();
        }

        [HttpDelete("notes/delete/{id:int}")]
        public async Task<IActionResult> DeleteNoteAsync([FromRoute]int id)
        {
            await noteService.DeleteAsync(id);
            return NoContent();
        }
    }
}