namespace src.Models;

public class News
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool IsApproved { get; set; }
}