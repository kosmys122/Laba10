namespace Боевая_Арена_с_Интерфейсами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new();
            arena.AddUnit(new Warrior("Парнап"));
            arena.AddUnit(new Mage("Гендальф"));
            arena.AddUnit(new Archer("Леголас"));
            arena.StartBattle();
        }
    }
}
