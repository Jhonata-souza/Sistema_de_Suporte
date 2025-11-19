using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SistemaSuporte.Api.Models;

public class User
{
    public int Id { get; set; }

    [Required, MaxLength(150)]
    public string Email { get; set; } = default!;

    [Required]
    [JsonIgnore] // nunca retorna hash em payloads
    public string PasswordHash { get; set; } = default!;

    public string? Name { get; set; }

    // Role: "User" ou "Admin"
    public string Role { get; set; } = "User";

    // Navigation
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

