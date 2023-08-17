namespace dz6;

class Program
{
    static void Main()
    {
        var planet1 = new { Name = "Венера", Number = 2, Length= 38025};
        var planet2 = new { Name = "Земля", Number = 3, Length= 40075, Previous = planet1};
        var planet3 = new { Name = "Марс", Number = 4, Length= 21326, Previous = planet2};
        var planet4 = new { Name = "Венера", Number = 2, Length= 38025};
        Console.WriteLine(planet1.ToString()+"Венера?: " + planet1==planet1.ToString());
    }
}
