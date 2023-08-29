using System.Xml.Linq;

namespace dz8;

class Program
{
    static void Main()
    {
        while (true)
        {
            Worker root = null;
            string name = string.Empty;
            int salary = 0;
            while (true)
            {
                Console.WriteLine("Enter worker's name. Type nothing to end");
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name))
                {
                    break;
                }
                Console.WriteLine("Enter worker's salary.");
                while (true)
                {
                    var readSalary = Console.ReadLine(); 
                    if (Int32.TryParse(readSalary, out salary))
                    {
                        break;
                    }
                    Console.WriteLine("Enter worker's salary.(Only int Values)");
                }
                    root = new Worker()
                    {
                        Salary = salary,
                        Name = name
                    };
                {
                    AddNode(root, new Worker
                    {
                        Salary = salary,
                        Name = name
                    });
                }
            }
            Console.WriteLine("Sorted workers:");
            Traverse(root);
            while (true)
            {
                Console.Write("Введите зарплату, которую хотите найти: ");
                while (!int.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Введите целочисленное значение");
                    Console.Write("Введите зарплату, которую хотите найти: ");
                }
                var employeeName = FindEmployeeBySalary(root, salary);
                Console.WriteLine(employeeName);

                int choise = 0;
                Console.WriteLine("Введите 0 для начала программы или 1 для повторного поиска зарплаты:");
                while (!int.TryParse(Console.ReadLine(), out choise))
                {
                    Console.WriteLine("Введите значение (0 или 1)");
                    Console.WriteLine("Введите 0 для перезапуска программы или 1 для повторного поиска зарплаты:");
                }
                if (choise == 1)
                    continue;
                else
                {
                    break;
                }
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
    static void Traverse(Worker originiNode)
    {

        if (originiNode.Left != null)
        {
            Traverse(originiNode.Left);
        }
        Console.WriteLine(String.Format("Имя сотрудника: {0}. Зарплата сотрудника: {1}.", originiNode.Name, originiNode.Salary));
        if (originiNode.Right != null)
        {
            Traverse(originiNode.Right);
        }
    }
    static string FindEmployeeBySalary(Worker root, int salary)
    {
        if (root == null)
        {
            return "такой сотрудник не найден";
        }

        if (salary == root.Salary)
        {
            return root.Name;
        }
        else if (salary < root.Salary)
        {
            return FindEmployeeBySalary(root.Left, salary);
        }
        else
        {
            return FindEmployeeBySalary(root.Right, salary);
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