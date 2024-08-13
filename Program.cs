namespace SumofArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the desired size of array:");
        int size;
        int.TryParse(Console.ReadLine(), out size);
        int[] array = new int[size];
        int total=0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Enter the desired value of array [{i}]:");
            int.TryParse(Console.ReadLine(), out array[i]);
            total+=array[i];
        }
        Console.WriteLine($"Total value of given array: {total}");
    }
}
