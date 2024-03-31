using System.Diagnostics;

    class Program
    {
        public static LinkedList<string> LinkedList = new LinkedList<string>();
        public static List<string> List = new List<string>();
        static void Main(string[] args)
        {
            LinkedList.AddFirst("a");
            LinkedList.AddFirst("b");

            var node = LinkedList.AddFirst("e");

            List.Add("c");
            List.Add("d");

            Console.WriteLine("LinkedList:");
            foreach (var item in LinkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List:");
            foreach (var item in List)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("\n");


            Stopwatch sw = Stopwatch.StartNew();

            LinkedList.AddAfter(node, "a");

            sw.Stop();
            Console.WriteLine($"Вставка в LinkedList - {sw.ElapsedTicks}");
            foreach (var item in LinkedList)
            {
                Console.WriteLine(item);
            }


            sw.Restart();

            List.Add("f");

            sw.Stop();
            Console.WriteLine($"Вставка в List - {sw.ElapsedTicks}");
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
        }
    }