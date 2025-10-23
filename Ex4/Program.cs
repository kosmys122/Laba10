using System.Linq;
namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>{"Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Казань", "Нижний Новгород", "Челябинск", "Самара", "Омск", "Ростов-на-Дону", "Уфа", "Красноярск", "Воронеж", "Пермь", "Волгоград"};
            var c1 = cities
                .Where(n => n[0] == 'К');
            Console.WriteLine(string.Join(", ", c1));
            var c2 = cities
                .OrderByDescending(n => n.Length);
            Console.WriteLine(string.Join(", ", c2));
            var c3 = cities
                .Where(n => n.Length>6);
            Console.WriteLine(string.Join(", ", c3));
        }
    }
}
