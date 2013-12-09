using System;
using System.Collections;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BST.Collections;
using BST.Collections.Collection;

namespace ConsoleTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Path temp = null;
            string key;
            var sortedBST = new System.Collections.Generic.SortedDictionary<string, Path>();
            while (true)
            {
                Console.WriteLine("##############################################");
                Console.WriteLine("Enter 0 to generate the path");
                Console.WriteLine("Enter 1 to insert into the tree");
                Console.WriteLine("Enter 2 to search in the tree by the key");
                Console.WriteLine("Enter 3 to delete from the tree by the key");
                Console.WriteLine("Enter 4 to clear the tree");
                Console.WriteLine("Enter 8 to show the tree");
                Console.WriteLine("Enter 9 to exit");
                Console.WriteLine("##############################################");
                int k = -1;
                if (int.TryParse(Console.ReadLine(), out k))
                {
                    switch (k)
                    {
                        case 0:
                            temp = new Path();
                            Console.WriteLine("Path is generated!");
                            Console.WriteLine(temp.Read());
                            break;
                        case 1:
                            if (temp != null)
                            {
                                Console.WriteLine("You should use as key words like 'bus', 'car', 'train', etc!");
                                Console.WriteLine("Enter new key!");
                                key = Console.ReadLine();
                                if (key != "")
                                {
                                    Console.WriteLine("key " + key + " path: " + temp.Read());
                                    sortedBST.Add(key, temp);
                                }
                                else
                                {
                                    Console.WriteLine("You're doing wrong!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Generate path before!");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter search key!");
                                key = Console.ReadLine();
                                if (key != "")
                                {
                                    Path sPath = null;
                                    Console.WriteLine("key " + key);
                                    if (sortedBST.ContainsKey(key))
                                    {
                                        if (sortedBST.TryGetValue(key, out sPath))
                                            Console.WriteLine(sPath.Read());
                                        else
                                        {
                                            Console.WriteLine("Can't get the path!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There is no key like this");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You're doing wrong!");
                                }
                            break;
                        case 3:
                            Console.WriteLine("Enter deleting key!");
                                key = Console.ReadLine();
                            if (key != "")
                            {
                                Console.WriteLine("key " + key);
                                if (sortedBST.ContainsKey(key))
                                {
                                    Console.WriteLine("key found!");
                                    if(sortedBST.Remove(key))
                                        Console.WriteLine("It's removed!");
                                    else
                                    {
                                        Console.WriteLine("Can't remove!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There is no key like this!");
                                }
                            }
                            break;
                        case 4:
                                Console.WriteLine("Are you sure? Type y to clear.");
                                char t;
                            if (char.TryParse(Console.ReadLine(), out t))
                            {
                                if (t == 'y')
                                {
                                    sortedBST.Clear();
                                    
                                    Console.WriteLine("Successfully cleared");
                                }
                                else
                                {
                                    Console.WriteLine("Okay.");
                                }
                            }
                            break;
                        case 8:
                            Console.WriteLine("Let's show tree.");
                            if (sortedBST.Keys.Count != 0)
                            {
                                System.Collections.Generic.SortedDictionary<string, Path>.Enumerator ic = sortedBST.GetEnumerator();
                               while (ic.MoveNext())
                                {
                                    Console.WriteLine(ic.Current.Key + " " + ((Path)ic.Current.Value).Read() + " ");
                                }
                                Console.WriteLine("Tree has showed.");
                            }
                            else
                            {
                                Console.WriteLine("Tree is gone.");
                            }
                            break;
                        case 9:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered wrong command! Try again.");
                }
            }

        }
    }
}
