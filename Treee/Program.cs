using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(0);
            Console.Write("Введите размер дерева ");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                //Tree tree = new Tree();
                //for (int i = 0; i < n; i++)
                //{
                //    tree.Insert(rnd.Next(100), tree.Root);
                //}
                //tree.Print(tree.Root);
                //Console.WriteLine($"Минимальное значение в дереве{tree.Min()}");
                //Console.WriteLine($"MAX значение в дереве{tree.Max()}");
                //Console.WriteLine($"Количество элементов дерева {tree.Count()}");



                UniquTree uniqu_tree = new UniquTree();
                for (int i = 0; i < n; i++)
                {
                    uniqu_tree.Insert(rnd.Next(100), uniqu_tree.Root);
                }
                uniqu_tree.Print(uniqu_tree.Root);
                Console.WriteLine($"Минимальное значение в дереве{uniqu_tree.Min()}");
                Console.WriteLine($"MAX значение в дереве{uniqu_tree.Max()}");
                Console.WriteLine($"Количество элементов дерева {uniqu_tree.Count()}");
                //Console.WriteLine($"Cумм элементов дерева:{uniqu_tree.Sum()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
