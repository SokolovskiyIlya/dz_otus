using System.Data.Common;

namespace Program2;

class Program2
{
    static void Main()
    {
      var catalog = new PlanetCatalog();
      List<(int? number,int? length,string error)> results = new List<(int? number,int? length,string error)>(){catalog.GetPlanet("Земля"), catalog.GetPlanet("Лимония"), catalog.GetPlanet("Марс")};
      foreach (var result in results)
      {
        if (result.number is null)
        {
            Console.WriteLine(result.error);
        }
        else
        {
            Console.WriteLine(catalog.PlanetsList.First(x=>x.Number==result.number).Name+" "+result.number.ToString()+" "+result.length.ToString()+" "+result.error);
        }
      }
    }
}
class PlanetCatalog
{
    public List<Planet> PlanetsList { get; set; }
    public int GetPlanetCounter { get; set; }
    public PlanetCatalog()
    {
        var venus = new Planet("Венера", 2, 38025, null);
        var earth = new Planet("Земля", 3, 40075, venus);
        var mars = new Planet("Марс", 4, 21326, earth);
        PlanetsList = new List<Planet>() { venus, earth, mars };
        GetPlanetCounter = 0;
    }
    public (int? number, int? length, string error) GetPlanet(string name)
    {
        GetPlanetCounter = GetPlanetCounter + 1;
        if (GetPlanetCounter % 3 != 0)
        {
            try
            {
                Planet foundPlanet = PlanetsList.First(x => x.Name == name);
                return (foundPlanet.Number, foundPlanet.Length, "");
            }
            catch
            {
                return (null, null, "Планета не найдена");
            }
        }
        else
        {
            return (null,null,"Вы спрашиваете слишком часто");
        }
    }
}
class Planet
{
    public string? Name { get; set; }
    public int Number { get; set; }
    public int Length { get; set; }
    public Planet? Previous { get; set; }
    public Planet(string name, int number, int length, Planet? previous)
    {
        Name = name;
        Number = number;
        Length = length;
        Previous = previous;
    }
}