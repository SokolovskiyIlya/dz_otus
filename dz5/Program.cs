using System;
class Program
{
  static void Main()
{
    Quadrocopter z12 = new Quadrocopter();
    var comps = z12.GetComponents();
    z12.Charge();
    System.Console.WriteLine(z12.GetInfo());
    System.Console.WriteLine(string.Join(",",comps));
}
}
public interface IRobot
{
    string GetInfo(){throw new NotImplementedException();}
    List<string> GetComponents();
    string GetRobotType()
    {
        return "I am a simple robot.";
    }
}
public interface IChargeable
{
    void Charge(){throw new NotImplementedException();}
    string GetInfo(){throw new NotImplementedException();}
}
public interface IFlyingRobot:IRobot
{
    new string GetRobotType()
    {
        return "I am a flying robot";
    }
}
class Quadrocopter:IFlyingRobot,IChargeable
{
  List<string> _components = new() {"rotor1","rotor2","rotor3","rotor4"};
    public List<string> GetComponents()
    {
        return _components;
    }
  public void Charge()
   {
    Console.WriteLine( "Charging...");
    Thread.Sleep(3000);
    Console.WriteLine("Charged!");
   }
   public string GetInfo()
   {
    return "I was made in China";
   }
   string GetRobotType()
   {
    return "Flying";
   }
}