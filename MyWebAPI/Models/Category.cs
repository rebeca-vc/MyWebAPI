using System.Diagnostics.CodeAnalysis;

namespace MyWebAPI.Models;

[ExcludeFromCodeCoverage]
public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }

}

