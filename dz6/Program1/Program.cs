namespace dz6;

class Program
{
    static void Main()
    {
        var planet1 = new { Name = "Венера", Number = 2, Length= 38025, Previous= null as object};
        var planet2 = new { Name = "Земля", Number = 3, Length= 40075, Previous = planet1};
        var planet3 = new { Name = "Марс", Number = 4, Length= 21326, Previous = planet2};
        var planet4 = new { Name = "Венера", Number = 2, Length= 38025, Previous= null as object};
        Console.WriteLine(planet1+String.Format(" Венера?: {0}", planet1.Equals(planet1)));
        Console.WriteLine(planet2+String.Format(" Венера?: {0}", planet2.Equals(planet1)));
        Console.WriteLine(planet3+String.Format(" Венера?: {0}", planet3.Equals(planet1)));
        Console.WriteLine(planet4+String.Format(" Венера?: {0}", planet4.Equals(planet1)));
    }
}
