using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Stack_
{
    internal class Program
    {
        static void Main()
        {
            var s = new Stack("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            var deleted = s.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
            s.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            //s.Pop();
            var s1 = new Stack("a", "b", "c");
            s1.Merge(new Stack("1", "2", "3"));
            var s2 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            Console.ReadLine();
        }
    }
    public class Stack
    {
        public List<string> items = new List<string>();
        public int Size { get; set; }
        public string Top { get; set; }
        public Stack()
        {
            this.Size = 0;
            this.Top = null;
        }
        public Stack(params string[] items)
        {
            foreach (var item in items) { this.items.Add(item); }
            this.Size = this.items.Count;
            this.Top = this.items.Last();
        }


        public void Add(string item)
        {
            this.items.Add(item);
            this.Top = item;
            this.Size++;
        }


        public string Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            this.items.RemoveAt(Size-1);
            Size--;
            string popedItem = this.Top;
            if (Size == 0)
            {
                this.Top = null;
            }
            else
            {
                this.Top = this.items.Last();
            } 
            return popedItem;
        }


         bool IsEmpty
        {
            get { return Size == 0; }
        }
        public static Stack Concat (params Stack[] stacks)
        {
            Stack result = new Stack(); 
            foreach (Stack stack in stacks)
            {
                while (!stack.IsEmpty)
                {
                    result.Add(stack.Pop());
                }
            }
            return (result);
        }
        private class StackItem
        {

        }
    }
    static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            while (s2.Size !=0) 
            {
                s1.Add(s2.Pop());
            }
        }
    }
}

