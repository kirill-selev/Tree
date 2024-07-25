//#define TREE_BASE_CHECK
//#define INITIALAZE
//#define PERFORMENS_CHEAK
//#define TREEPRINTCHEAK
#define BALANS_CHEAK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using Treee;
namespace BinaryTree

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(0);
            if (true)
            {
                //Console.Write("Введите размер дерева ");
#if TREE_BASE_CHECK
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
                    List<int> list = new List<int>();

                    for (int i = 0; i < n; i++)
                    {
                        list.Add(rnd.Next(100));
                        Console.Write(list.Last());
                        uniqu_tree.Insert(list.Last());
                    }
                    uniqu_tree.Print(uniqu_tree.Root);
                    Console.WriteLine($"Минимальное значение в дереве{uniqu_tree.Min()}");
                    Console.WriteLine($"MAX значение в дереве{uniqu_tree.Max()}");
                    Console.WriteLine($"Количество элементов дерева {uniqu_tree.Count()}");
                    
                    Console.WriteLine($"Сумма элементов дерева: {uniqu_tree.Sum()}");
				    Console.WriteLine($"Среднее-арифметическое элементов дерева: {uniqu_tree.Avg()}");




                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }  
#endif
#if INITIALAZE
                try
                {
                    Tree uniqu_tree = new Tree() { 50, 25, 75, 16, 32, 64, 91, 98, 2000 };
                    List<int> list = new List<int>();


                    uniqu_tree.Print(uniqu_tree.Root);
                    Console.WriteLine($"Минимальное значение в дереве{uniqu_tree.Min()}");
                    Console.WriteLine($"MAX значение в дереве{uniqu_tree.Max()}");
                    Console.WriteLine($"Количество элементов дерева {uniqu_tree.Count()}");

                    Console.WriteLine($"Сумма элементов дерева: {uniqu_tree.Sum()}");
                    Console.WriteLine($"Среднее-арифметическое элементов дерева: {uniqu_tree.Avg()}");
                    Console.WriteLine($"Глубина дерева  {uniqu_tree.Detph()}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                } 
#endif
#if PERFORMENS_CHEAK
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
                    List<int> list = new List<int>();

                    for (int i = 0; i < n; i++)
                    {
                        list.Add(rnd.Next(100));
                        Console.Write(list.Last());
                        uniqu_tree.Insert(list.Last());
                    }
                    //Измеряем произвадительность :
                    Stopwatch sw = new Stopwatch();



                    #region Stupid performance measuring
                    //Console.WriteLine($"Минимальное значение в дереве{uniqu_tree.Min()}");


                    //Console.WriteLine($"MAX значение в дереве{uniqu_tree.Max()}");
                    //Console.WriteLine($"Количество элементов дерева {uniqu_tree.Count()}");

                    //Console.WriteLine($"Сумма элементов дерева: {uniqu_tree.Sum()}");
                    //Console.WriteLine($"Среднее-арифметическое элементов дерева: {uniqu_tree.Avg()}");
                    //sw.Start();
                    //Console.WriteLine($"Глубина дерева  {uniqu_tree.Detph()}");
                    //sw.Stop();
                    //Console.WriteLine($"Вычеслено за {sw.Elapsed}");
                    //Console.WriteLine($"Вычеслено за {sw.Elapsed.TotalMilliseconds}"); 
                    #endregion
                    uniqu_tree.Print();
                    TreePerformens_cs<int>.Measure("минимальное значение в дереве ", uniqu_tree.Min);
                    TreePerformens_cs<int>.Measure("максимальное  значение в дереве ", uniqu_tree.Max);
                    TreePerformens_cs<int>.Measure("cymma элементов дерева ", uniqu_tree.Sum);
                    TreePerformens_cs<int>.Measure("Количество элементов дерева ", uniqu_tree.Count);
                    TreePerformens_cs<double>.Measure("AVG элементов дерева ", uniqu_tree.Avg);
                    TreePerformens_cs<int>.Measure("Глубина элементов дерева ", uniqu_tree.Depth);


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                } 
#endif
#if TREEPRINTCHEAK
                Tree tree = new Tree() { 50, 25, 75, 16, 32, 64, 91, 98 };
                tree.Print();
                Console.WriteLine();
                //Console.Write("Ведите глубину:");
                //int depth = Convert.ToInt32(Console.ReadLine());
                //tree.Print(depth);
                tree.TreePrint();
                tree.Erase(50);
                tree.TreePrint();
#endif
#if BALANS_CHEAK
                Tree tree = new Tree() { 89, 55, 34, 21, 13, 8, 5, 3 };
                tree.TreePrint(); 
                tree.Balance();
                tree.TreePrint();
#endif
            }
        }
    }
}
