using System.ComponentModel.DataAnnotations;


public class Country
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Capital { get; set; }

    public string Region { get; set; }
    public long Population { get; set; }
    public double Area { get; set; }
    public string Currency { get; set; }
    public string Language { get; set; }
    public string TimeZone { get; set; }
    public string Continent { get; set; }
}
