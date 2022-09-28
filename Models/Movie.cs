namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title{get;set;}
    public DateTime ReleaseDate {get;set;}
    public string Genre {get;set;}
    public string Price{get;set;}
    public Movie(int Id,string Title,DateTime ReleaseDate,string Genre,string Price)
    {
        this.Id=Id;
        this.Title=Title;
        this.ReleaseDate=ReleaseDate;
        this.Genre =Genre;
        this.Price=Price;
    }
    
}
