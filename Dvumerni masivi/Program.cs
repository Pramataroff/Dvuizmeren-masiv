namespace Dvumerni_masivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter colona:");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];
            for     (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
