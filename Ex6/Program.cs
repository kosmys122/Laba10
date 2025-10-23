using System.Xml.Linq;

namespace Ex6
{
    internal class Program
    {
        static async Task LoadStudentsAsync()
        {
            Console.WriteLine("Подожните 3 секунды");
            await Task.Delay(3000);
        }
        static async Task Main()
        {
            List<Student> students=new()
            {
                new Student{Name="Рома",Age=5},
                new Student{Name="Алёна",Age=13},
                new Student{Name="Дима",Age=51},
                new Student{Name="Майкл",Age=18},
                new Student{Name="Олег",Age=21}
            };
            List<Teacher> teachers=new()
            {
                new Teacher{Name="Денис",Kaf="a1"},
                new Teacher{Name="Маргарита",Kaf="a2"},
                new Teacher{Name="Дима",Kaf="a1"},
                new Teacher{Name="Лариса",Kaf="a2"},
                new Teacher{Name="Дарья",Kaf="a2"}
            };
            var s1 = students.Where(s => s.Age > 20);
            var t1 = teachers.Where(t => t.Kaf == "a1");
            var s2 = students.OrderBy(s => s.Name);
            var t2 = teachers.OrderBy(t => t.Name);
            Console.WriteLine("Все студенты старше 20 лет.");
            await LoadStudentsAsync();
            foreach (var s in s1)
            {
                Console.WriteLine($"Имя студента {s.Name}, его возраст {s.Age}");
            }
            Console.WriteLine("Учителя с определённой кафедры a1");
            await LoadStudentsAsync();
            foreach (var t in t1)
            {
                Console.WriteLine($"Имя преподавателя {t.Name}, его кафедра {t.Kaf}");
            }
            Console.WriteLine("Происходит сортировка по имени");
            await LoadStudentsAsync();
            Console.WriteLine("Студенты");
            foreach (var s in s2)
            {
                Console.WriteLine($"Имя студента {s.Name}, его возраст {s.Age}");
            }
            Console.WriteLine("Преподователи");
            foreach (var t in t2)
            {
                Console.WriteLine($"Имя преподавателя {t.Name}, его кафедра {t.Kaf}");
            }
        }
    }
}
