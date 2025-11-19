using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaSuporte.Api.Models;

public class Comment
{
    public int Id { get; set; }

    [Required]
    public int TicketId { get; set; }
    public Ticket? Ticket { get; set; }

    [Required]
    public int AuthorId { get; set; }
    public User? Author { get; set; }

    [Required]
    public string Text { get; set; } = default!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

