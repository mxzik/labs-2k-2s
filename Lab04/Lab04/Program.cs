using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02; // for another class

namespace Lab04
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            CollectionType<int> cc = new CollectionType<int>(10);
            cc.Add(12); cc.Add(2);
            Console.WriteLine($"Test collection with struct:");
            Console.WriteLine($"Length: {cc.Count}");
            foreach (var item in cc)
            {
                Console.Write($"{item}  ");
            }
            try
            {
                Console.WriteLine($"\nContains '12':  {cc.Contains(12)}");
                Console.WriteLine($"Contains '13':  {cc.Contains(13)}");
                Console.WriteLine($"Index of 12 { cc.IndexOf(12)} ");
                Console.WriteLine($"Index of 2 { cc.IndexOf(2)} ");
                Console.WriteLine($"Index of 22 { cc.IndexOf(22)} ");
                cc.Add(13); cc.Add(13); cc.Add(66); cc.Add(123); cc.Add(133);
                foreach (var item in cc)
                {
                    Console.Write($"{item} ");
                }
                cc.Insert(0, 666);
                //cc.Insert(66, 666);
                Console.WriteLine("\nInsert 66 on 0 place:");
                foreach (var item in cc)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Remove 13 {cc.Remove(13)}");
                Console.WriteLine($"Remove 667 {cc.Remove(667)}");
                Console.WriteLine("Delete element with 0 index");
                cc.RemoveAt(0);
                foreach (var item in cc)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine($"\nTest collection with user's class {typeof(TextBox)}");
                TextBox[] a = new TextBox[4];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new TextBox($"TextBox{i}");
                }
                var ss = new CollectionType<TextBox>(4);
                ss.Add(a[0]); ss.Add(a[1]); ss.Add(a[2]); ss.Add(a[3]);
                ss.ToFile();
                //ss.DeleteFile();
                Console.WriteLine($"Test LINQ with CollectionType:");
                CollectionType<int>[] arrCollections = new CollectionType<int>[] 
                        { new CollectionType<int>(5) { -1, -3, 2, 11, 4 },
                          new CollectionType<int>(4) { -2, 2, 3, 4 },
                          new CollectionType<int>(8) { 3, 4, 44, 5, 66, 77, 8, 90 },
                          new CollectionType<int>(7) { 1, 77, 2, 22, 222, 2222, 23 }
                        };
                //////
                int min = arrCollections.Min(coll => coll.Count);
                var Min = from coll in arrCollections
                          where coll.Count == min
                          select coll;
                foreach (var item in Min)
                {
                    Console.WriteLine("Minimal collection");
                    foreach (var item1 in item)
                    {
                        Console.Write($"{item1}  ");
                    }
                }
                Console.WriteLine();
                int max = arrCollections.Max(coll => coll.Count);
                var Max = from coll in arrCollections
                          where coll.Count == max
                          select coll;
                foreach (var item in Max)
                {
                    Console.WriteLine("Maximal collection");
                    foreach (var item1 in item)
                    {
                        Console.Write($"{item1}  ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"LINQ with List<string>: ");
                Console.WriteLine("Before sort");
                List<string> ListString = new List<string>(6)
                                         {
                                            "qwerty", "Hello world", "1", 
                                            "ytrewq", "ggg", "12"
                                         };
                foreach (var item in ListString)
                {
                    Console.WriteLine(item);
                }
                ListString.Sort();
                Console.WriteLine("\nAfter upper sort");
                foreach (var item in ListString)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nAfter lower sort in linq");
                var aaaa = ListString.ToArray()
                                           .OrderByDescending(s => s);
                foreach (var item in aaaa)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Console.WriteLine();
                var count = ListString.Count(n => n.Length <= 3);
                Console.WriteLine($"Count string with length <= 3 :  {count}");
                Console.WriteLine($"Output string with 'w' :");
                var stringWithValue = from s in ListString where s.Contains("w") == true select s;
                foreach (var item in stringWithValue)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError:");
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                Console.WriteLine("It's all!");
            }

        }
    }
}
