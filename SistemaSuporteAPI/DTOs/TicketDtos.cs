namespace SistemaSuporte.Api.DTOs;

public record CreateTicketDto(string Title, string? Description, string? Priority);
public record UpdateStatusDto(string Status);
public record AddCommentDto(string Text);