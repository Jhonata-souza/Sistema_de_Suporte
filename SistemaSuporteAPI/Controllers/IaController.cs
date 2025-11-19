using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaSuporte.Api.DTOs;
using SistemaSuporte.Api.Services;

namespace SistemaSuporte.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class IaController : ControllerBase
{
    private readonly IIaService _ia;

    public IaController(IIaService ia) => _ia = ia;

    [HttpPost("ask")]
    public async Task<IActionResult> Ask([FromBody] IaRequestDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Prompt)) return BadRequest("Prompt is required.");
        var answer = await _ia.AskAsync(dto.Prompt);
        return Ok(new IaResponseDto(answer));
    }
}
