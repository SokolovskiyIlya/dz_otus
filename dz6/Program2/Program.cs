namespace Program2;

class Program2
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
class PlanetCatalog
{
    public List<Planet> PlanetsList { get; set; }
    public PlanetCatalog()
    {
        PlanetsList = new List<Planet>(){new Planet("Венера", 123,123, new Planet())}
    }
    public GetPlanet(string name)
    {

    }

}
class Planet
{
    public string Name { get; set; }
    public int Number { get; set; }
    public int Length { get; set; }
    public Planet Previous { get; set;}
    public Planet(string name, int number, int length, Planet previous)
    {
        Name=name;
        Number=number;
        Length=length;
        Previous=previous;
    }
}

