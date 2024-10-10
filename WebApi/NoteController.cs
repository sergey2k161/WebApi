using BussinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebApi;

[ApiController]
[Route("Note")]
public class NoteController(INoteService noteSerivce) : ControllerBase
{
    [HttpPost("/create/note")]
    public async Task<IActionResult> CreateAsync(string text)
    {
        await noteSerivce.CreateAsync(text);
        return NoContent();
    }
    
    [HttpGet("/get/byId/{id:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var result = await noteSerivce.GetByIdAsync(id);
        return Ok(result);
    }
}
