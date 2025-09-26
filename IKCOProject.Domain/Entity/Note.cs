﻿namespace IKCOProject.Domain.Entity;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}