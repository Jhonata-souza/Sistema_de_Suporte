using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using SistemaSuporte.Api.Data;
using SistemaSuporte.Api.DTOs;
using SistemaSuporte.Api.Models;

namespace SistemaSuporte.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class TicketsController : ControllerBase
{
    private readonly AppDbContext _db;
    public TicketsController(AppDbContext db) => _db = db;

    private int CurrentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "0");
    private string CurrentUserRole => User.FindFirstValue(ClaimTypes.Role) ?? "User";

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IQueryable<Ticket> q = _db.Tickets.Include(t => t.Comments).Include(t => t.User);
        if (CurrentUserRole != "Admin")
            q = q.Where(t => t.UserId == CurrentUserId);

        var list = await q.OrderByDescending(t => t.CreatedAt).ToListAsync();
        return Ok(list);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var t = await _db.Tickets.Include(x => x.Comments).FirstOrDefaultAsync(x => x.Id == id);
        if (t == null) return NotFound();
        if (CurrentUserRole != "Admin" && t.UserId != CurrentUserId) return Forbid();
        return Ok(t);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTicketDto dto)
    {
        var ticket = new Ticket
        {
            Title = dto.Title,
            Description = dto.Description,
            Priority = dto.Priority,
            UserId = CurrentUserId,
            CreatedAt = DateTime.UtcNow,
            Status = "Aberto"
        };

        _db.Tickets.Add(ticket);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = ticket.Id }, ticket);
    }

    [HttpPut("{id:int}/status")]
    public async Task<IActionResult> UpdateStatus(int id, [FromBody] UpdateStatusDto dto)
    {
        var t = await _db.Tickets.FindAsync(id);
        if (t == null) return NotFound();
        if (CurrentUserRole != "Admin" && t.UserId != CurrentUserId) return Forbid();

        t.Status = dto.Status;
        if (dto.Status == "Resolvido") t.ClosedAt = DateTime.UtcNow;
        await _db.SaveChangesAsync();
        return NoContent();
    }

    [HttpPost("{id:int}/comment")]
    public async Task<IActionResult> AddComment(int id, [FromBody] AddCommentDto dto)
    {
        var t = await _db.Tickets.FindAsync(id);
        if (t == null) return NotFound();
        if (CurrentUserRole != "Admin" && t.UserId != CurrentUserId) return Forbid();

        var comment = new Comment
        {
            TicketId = id,
            AuthorId = CurrentUserId,
            Text = dto.Text,
            CreatedAt = DateTime.UtcNow
        };

        _db.Comments.Add(comment);
        await _db.SaveChangesAsync();
        return Ok(comment);
    }
}
