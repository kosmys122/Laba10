namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> items = new List<IPrintable>
            {
                new Book{Name="Война и мир"},
                new Magazine{Name="Сметана"}
            };
            foreach(var item in items)
            {
                item.PrintInfo();
            }
        }
    }
}
