using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace MyWebAPI.Models;

[ExcludeFromCodeCoverage]
public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public ICollection<Product>? Products => new Collection<Product>();

}

