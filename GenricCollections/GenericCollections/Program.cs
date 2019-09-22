using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCollection();
            LinkedListCollection();
            QueueCollection();
            StackCollection();
            DictionaryCollection();
            SortedListCollection();
            HashSetCollection();
        }
        public static void ListCollection() //able to add and remove easily
        {
            Console.WriteLine("- List<T> Collection");
            List<string> movies = new List<string>(new string[8] { "It", "Moana", "Frozen", "Up", "Toy Story", "Sleep Beauty", "Aladdin", "Brave"});
            Console.WriteLine("Movie Collection: ");
            foreach (string name in movies)
            {
                Console.WriteLine($"\t{name}");
            }

            Console.WriteLine("Removing Toy Story: ");
            movies.Remove("Toy Story");
            foreach (string name in movies)
            {
                Console.WriteLine($"\t{name}");
            }

            Console.WriteLine("Adding Cars: ");
            movies.Add("Cars");
            foreach (string name in movies)
            {
                Console.WriteLine($"\t{name}");
            }

        }

        public static void LinkedListCollection()
        {
            Console.WriteLine("\n- LinkedList<T> Collection");
            LinkedList<int> numbers = new LinkedList<int>();
            Console.WriteLine("LinkedList Collection: ");

            foreach (int number in new int[5] { 50, 40, 30, 20, 10 })
            {
                numbers.AddFirst(number);
            }

            foreach(int number in numbers)
            {
                Console.WriteLine($"\t{number}");
            }

            Console.WriteLine("Reverse of the LinkedList Collection");
            for(LinkedListNode<int> node = numbers.Last; node != null; node = node.Previous)
            {
                int number = node.Value;
                Console.WriteLine($"\tnumber");
            }
        }

        public static void QueueCollection() // gets rid of the oldest one first
        {
            Console.WriteLine("\n- Queue<T> Collection");
            Queue<int> ages = new Queue<int>();
            Console.WriteLine("Queue<t> Collection");

            foreach (int age in new int[5] { 52, 21, 5, 19, 7 })
            {
                ages.Enqueue(age);
                Console.WriteLine($"\t{age} has joined the queue");
            }

            Console.WriteLine("Draining the queue");
            while (ages.Count > 0)
            {
                int age = ages.Dequeue();
                Console.WriteLine($"\t{age} has left the queue");
            }
        }

        public static void StackCollection() //last hired, first fired
        {
            Console.WriteLine("\n- Stack<T> Collection");
            Stack<int> ages = new Stack<int>();

            Console.WriteLine("Queue Contains");

            foreach (int age in new int[5] { 100, 50, 30, 20, 10 })
            {
                ages.Push(age);
                Console.WriteLine($"\t{age}");
            }
            Console.WriteLine("Last entry = first entry to go");
            while (ages.Count > 0)
            {
                int age = ages.Pop();
                Console.WriteLine($"\t{age}");
            }
        }

        public static void DictionaryCollection() // bascially like a dictionary
        {
            Console.WriteLine("\n- Dictionary<TKey, TValue> Collection");
            Dictionary<string, string> names = new Dictionary<string, string>();

            names.Add("Bob", "Smith"); //add method
            names.Add("Timmy", "Roy");
            names["Sally"] = "Yu"; // array notation
            names["Lily"] = "Rose";
            names["Bri"] = "Hut";

            Console.WriteLine("The contacts book contains: ");
            foreach (KeyValuePair<string, string> element in names)
            {
                string firstName = element.Key;
                string lastName = element.Value;
                Console.WriteLine($"\tName: {firstName} {lastName}");
            }

        }

        public static void SortedListCollection() // sorts the dictionary in ABC order
        {
            Console.WriteLine("\n- SortedList<TKey, TValue> Collection");
            SortedList<string, string> names = new SortedList<string, string>();

            names.Add("Bob", "Smith"); //add method
            names.Add("Timmy", "Roy");
            names["Sally"] = "Yu"; // array notation
            names["Lily"] = "Rose";
            names["Bri"] = "Hut";

            Console.WriteLine("The sorted contacts book contains: ");
            foreach (KeyValuePair<string, string> element in names)
            {
                string firstName = element.Key;
                string lastName = element.Value;
                Console.WriteLine($"\tName: {firstName} {lastName}");
            }
        }

        public static void HashSetCollection() // good for combining
        {
            Console.WriteLine("\n- HashSet<T> Collection");
            HashSet<string> stores = new HashSet<string>(new string[5] {"Walmart", "Target", "Walgreens", "CVS", "Costco"});
            HashSet<string> products = new HashSet<string>(new string[5] { "toilet paper", "soda", "chips", "tooth brush", "napkins" });

            stores.Add("Dollar Tree");
            products.Add("ice cream");

            Console.WriteLine("Store purchases: ");
            foreach (string name in products)
            {
                Console.WriteLine($"\t{name}");
            }

            Console.WriteLine("Stores you can get it from: ");
            products.IntersectWith(stores);
            foreach(string name in stores)
            {
                Console.WriteLine($"\t{name}");
            }         
        }
    }
}
