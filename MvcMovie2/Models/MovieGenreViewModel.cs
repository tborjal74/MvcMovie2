using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie2.Models;

namespace MvcMovie2.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }


    public SelectList? Years { get; set; }
    public int? SelectedYear { get; set; }

    public string? YearDirection { get; set; }
}