namespace src.Models;

public class Food
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? VideoUrl { get; set; }

    public string? ImageUrl { get; set; }

    public string? Diet { get; set; }

    public bool IsApproved { get; set; }
}