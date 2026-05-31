using Homework2;
using static Homework2.ShiftingArray;

internal class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        ShiftingArray array = new ShiftingArray(size);

        Console.WriteLine("Enter array elements:");
        array.FillArray();

        Console.Write("Enter rotation count k: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter direction (Left / Right): ");
        string input = Console.ReadLine();

        if (!Enum.TryParse(input, true, out RotationDirection direction))
        {
            Console.WriteLine("Invalid direction.");
            return;
        }

        array.Rotate(k, direction);

        Console.WriteLine("Rotated array:");
        array.PrintArray();
    }
}
