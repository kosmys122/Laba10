using System.Linq;
using System.Collections.Generic;
namespace Async
{
    internal class Program
    {
        static IEnumerable<int> GenerateNumbers()
        {
            Console.WriteLine("Начинаем генерацию");
            yield return 1;
            Console.WriteLine("Пауза");
            yield return 2;
            Console.WriteLine("И ещё раз");
            yield return 3;
            Console.WriteLine("Готово!");
        }
        delegate int MathOperation(int a, int b);
        static async Task Main()
        {
            //Console.WriteLine("1. Включили чайник...");
            //Task boilTask = BoilWaterAsync();
            //Task sliceTask=SliceLemonAsync();
            //await Task.WhenAll(boilTask, sliceTask);
            //Console.WriteLine("4. Завариваем чай!");
            //foreach (int num in GenerateNumbers())
            //{
            //    Console.WriteLine($"Получено число: {num}");
            //}
            //List<int> num = new List<int> { 5, 2, 9, 4, 7, 3, 8, 24, 54, 52, 7, 48, 857 };
            //List<int> evenNum = new List<int>();
            //foreach (var n in num)
            //{
            //    if (n % 2 == 0)
            //        evenNum.Add(n);
            //}
            //List<int> multiplied = new List<int>();
            //foreach (var n in evenNum)
            //{
            //    multiplied.Add(n * 10);
            //}
            //multiplied.Sort((a, b) => b.CompareTo(a));
            //Console.WriteLine("Результат без LINQ");
            //foreach (var n in multiplied)
            //{
            //    Console.WriteLine(n);
            //}
            //var res = num
            //    .Where(n => n % 2 == 0)
            //    .Select(n => n * 10)
            //    .OrderByDescending(n => n);
            //Console.WriteLine("Результат с LINQ");
            //foreach(var n in res)
            //{
            //    Console.WriteLine(n);
            //}
            //List<string> names = new List<string> { "Anna", "Иван", "Maрия", "Пётр" };
            //var linqLongNames = names.Where(name => name.Length > 4);
            //foreach (var name in linqLongNames)
            //{
            //    Console.WriteLine(name);
            //}
            //List<int> nums = new List<int> { 10, 5, 20, 3 };
            //int linqmin = nums.Min();
            //Console.WriteLine($"Минимальное число {linqmin}");
            //var linqSquares = num.Select(n => n * n);
            //Console.WriteLine(string.Join(", ",linqSquares));
            //List<Student> students = new()
            //{
            //    new Student {Name="Андрей",Score=90},
            //    new Student {Name="Вика",Score=78},
            //    new Student {Name="Денис",Score=84},
            //    new Student {Name="Лена",Score=95},
            //    new Student {Name="Олег",Score=65}
            //};
            //List<Student> goodStudents = new List<Student>();
            //int total = 0;
            //foreach(var s in students)
            //{
            //    total += s.Score;
            //    if (s.Score > 80)
            //        goodStudents.Add(s);
            //}
            //goodStudents.Sort((a, b) => a.Name.CompareTo(b.Name));
            //foreach (var s in goodStudents)
            //{
            //    Console.WriteLine(s.Name);
            //}
            //Console.WriteLine($"Средний бал: {(double)total/students.Count:F1}");
            //var goodStudent = students
            //    .Where(s => s.Score > 80)
            //    .OrderBy(s => s.Name);
            //var averageScore = students.Average(s => s.Score);
            //foreach(var s in goodStudent)
            //{
            //    Console.WriteLine(s.Name);
            //}
            //Console.WriteLine(averageScore);
            //Console.WriteLine("Начинаем готовить ужин...");
            //await CookDinnerAsync();
            //Console.WriteLine("Ужин готов!");
            //Func<int, int, int> sum = (a, b) => a + b;
            //Console.WriteLine(sum(3,7));
            //Func<int, string> numberToWord = num =>
            //{
            //    switch (num)
            //    {
            //        case 1: return "один";
            //        case 2: return "два";
            //        default: return "много";
            //    }
            //};
            //Console.WriteLine(numberToWord(2));
            //MathOperation add = (a, b) => a + b;
            //Console.WriteLine(add(2,3));
            //foreach (var step in WaitCoroutine())
            //{
            //    Console.WriteLine(step);
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("Готово!");
            //Console.WriteLine("Начинаем...");
            //await Task.Delay(2000);
            //Console.WriteLine("Готово!");















        }
        static async Task BoilWaterAsync()
        {
            Console.WriteLine("2. Кипятим воду (ждём 3 секунды)...");
            await Task.Delay(3000);
            Console.WriteLine("...вода вскипела");
        }
        static async Task SliceLemonAsync()
        {
            Console.WriteLine($"Режем лимон (ждём 2 секунды)...");
            await Task.Delay(2000);
            Console.WriteLine("...лимон порезан!");
        }
        class Student
        {
            public string Name;
            public int Score;
        }
        public static async Task<string> MakeSoupAsync()
        {
            Console.WriteLine("Начинаем варить суп...");
            await Task.Delay(3000);
            return "Суп";
        }
        public static async Task<string> MakeSaladAsync()
        {
            Console.WriteLine("Начинаем резать салат...");
            await Task.Delay(1000);
            return "Салат";
        }
        public static async Task CookDinnerAsync()
        {
            Task<string> soupTask = MakeSoupAsync();
            Task<string> saladTask = MakeSaladAsync();
            string soup = await soupTask;
            string salad = await saladTask;

            Console.WriteLine($"Готово: {soup} и {salad}");
        }
        static IEnumerable<string> WaitCoroutine()
        {
            yield return "Ждём... 1 секунда";
            yield return "Ждём... 2 секунды";
        }
    }
}
