namespace dz8;

class Program
{
    static void Main()
    {
        Worker root = null;
        while (true)
        {
            var name = Console.ReadLine();
            var salary = double.Parse(Console.ReadLine());
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
    static void AddNode(Worker root, Worker toAdd)
    {
        if (toAdd.Salary < root.Salary)
        {
            if (root.Left != null)
            {
                AddNode(root.Left, toAdd);
            }
            else
            {
                root.Left = toAdd;
            }
        }
        else
        {

            if (root.Right != null)
            {
                AddNode(root.Right, toAdd);
            }
            else
            {
                root.Right = toAdd;
            }
        }
    }
}
public class Worker
{
    public double Salary { get; set; }
    public string Name { get; set; }
    public Worker Left { get; set; }
    public Worker Right { get; set; }
}