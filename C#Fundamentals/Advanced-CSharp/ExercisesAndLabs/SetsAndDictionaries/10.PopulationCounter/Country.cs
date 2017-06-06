using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Country
{
    public Country(string name)
    {
        this.Name = name;
        this.Cities = new List<City>();
    }

    public string Name { get; set; }
    public List<City> Cities { get; set; }
    public long TotalPopulation { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Name} (total population: {this.TotalPopulation})");
        foreach (var city in this.Cities.OrderByDescending(x => x.Population))
        {
            sb.AppendLine($"=>{city.Name}: {city.Population}");
        }

        return sb.ToString();
    }
}