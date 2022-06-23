namespace PUP56.Models;

public class Movie
{
    public bool Adult { get; set; } = false;
    public int? Budget { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalTitle { get; set; }
    public string? Overview { get; set; }
    public string? Title { get; set; }
    public double VoteAverage { get; set; }
    public string? ReleaseDate { get; set; }
}
