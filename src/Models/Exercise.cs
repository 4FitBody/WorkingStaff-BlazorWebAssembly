namespace src.Models;

public class Exercise
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? BodyPart { get; set; }

    public string? Equipment { get; set; }

    public string? GifUrl { get; set; }

    public string? Target { get; set; }

    public string?[]? SecondaryMuscles { get; set; }

    public string?[]? Instructions { get; set; }

    public bool IsApproved { get; set; }
}