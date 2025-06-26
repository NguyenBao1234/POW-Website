namespace POWStudio.Models;

public class Game
{
    public string? Title { get; set; }
    public string? Slug { get; set; } = string.Empty;
    public string? TittleImageUrl { get; set; } = string.Empty;
    public string? ShortDescription { get; set; } = string.Empty;
    public string? DetailedDescription { get; set; } = string.Empty;
    public string? BgImageUrl { get; set; } = string.Empty;
    public string? TrailerUrl { get; set; }
    public string? ItchioUrl { get; set; } = string.Empty;
    public string? SteamUrl { get; set; }
    public string? EpicUrl { get; set; }
    public string? FabUrl { get; set; }
}