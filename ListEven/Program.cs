namespace ListEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listEven = new List<int>();
            List<int> listOdd = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    listEven.Add(list[i]);
                }
                else
                {
                    listOdd.Add(list[i]);
                }
            }
            Console.WriteLine("Chetni " + string.Join(" ", listEven));
            Console.WriteLine("Nechetni" + string.Join("", listOdd));


        }
        static List<int> GetEventElements(List<int> list)
        {
            List<int> listOdd = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    listEven.Add(list[i]);
                }
            }
            return listOdd;

        }
    }
}
