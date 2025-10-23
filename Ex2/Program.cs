namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> nums2 = nums1.FindAll(x => x % 2 == 0);
            List<int> nums3 = nums1.FindAll(x => x % 3 == 0);
            Console.WriteLine(string.Join(", ", nums2));
            Console.WriteLine(string.Join(", ", nums3));
        }
    }
}
