namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new{Name="Рома",Age=5,Group="ИСП-231"},
                new{Name="Алёна",Age=13,Group="ИСП-23113"},
                new{Name="Дима",Age=51,Group="ЮСП-32"},
                new{Name="Майкл",Age=18,Group="ЭСП-3"},
                new{Name="Олег",Age=21,Group="ЗСП-9"}
            };
            foreach(var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age}, {student.Group}.");
            }
        }
    }
}
