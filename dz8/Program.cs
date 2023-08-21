namespace dz8;

class Program
{
    static void Main()
    {
        while (true)
        {
            var name = Console.ReadLine();
            var salary = double.Parse(Console.ReadLine());
            Worker root = null;
            if (String.IsNullOrEmpty(name))
            {
                break;
            }
            if (root == null)
            {
                root = new Worker()
                {
                    Salary = salary,
                    Name = name
                };
            }
            else
            {
                AddNode(root, new Worker
                {
                    Salary = salary,
                    Name = name
                });
            }
        }
    }

}
public class Worker
{
    public double Salary { get; set; };
    public string Name { get; set; };
    public Worker Left { get; set; };
    public Worker Right { get; set; };
}
