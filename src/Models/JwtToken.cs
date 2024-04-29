#pragma warning disable CS8618

namespace src.Models;

public class JwtToken
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}