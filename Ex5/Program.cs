namespace Ex5
{
    internal class Program
    {
        static async Task<int> GetDataAsync(int a)
        {
            Console.WriteLine("Ждём данные…");
            await Task.Delay(2000);
            Console.WriteLine("Данные получены!");
            return a;
        }
        static async Task Main()
        {
            await GetDataAsync(5);
            await GetDataAsync(2);
        }
    }
}
