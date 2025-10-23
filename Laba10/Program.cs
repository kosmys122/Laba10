using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Laba10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var monster = new
            //{
            //    Name = "Dragon",
            //    Damage = 45_00,
            //    IsBoss = true,
            //    DescriptionAttribute = "Old Fire Dragon"
            //};
            //Student student = new Student();
            //student.Name = "Andrey";
            //student.University = "ВФ Волгу";
            //student.SayHello();
            //Console.WriteLine($"Учится в {student.University}");
            //Cat cat = new() { Name = "Мурзик" };
            //Dog dog = new() { Name = "Бобик" };
            //cat.MakeSound();
            //cat.Info();
            //dog.MakeSound();
            //dog.Info();
            //List<ISound> sounds= new List<ISound>{ new Bird(),new Phone()};
            //foreach(var sound in sounds)
            //{
            //    sound.MakeSound();
            //}
            //Animal[] animals =
            //{
            //    new Dog {Name="Бобик"},
            //    new Cat {Name="Мурка"}
            //};
            //foreach (var animal in animals)
            //{
            //    animal.Info();
            //    animal.MakeSound();
            //}

        }
    }
    public class Person()
    {
        public string Name { get; set; }
        public virtual void SayHello()
        {
            Console.WriteLine($"Привет, меня зовут {Name}");
        }
    }
    public class Student: Person
    {
        public string University {  get; set; }
        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine($"учусь в {University}");
        }
    }
}
