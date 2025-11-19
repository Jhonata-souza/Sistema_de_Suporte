using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaSuporte.Api.Models;

public class Ticket
{
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required, MaxLength(250)]
    public string Title { get; set; } = default!;

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public string Status { get; set; } = "Aberto";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? ClosedAt { get; set; }

    public string? AiSummary { get; set; }

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}

