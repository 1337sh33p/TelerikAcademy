using System;

class Program
{
    static void Main()
    {
        string maxSize = Console.ReadLine();
        string [] arr = maxSize.Split(' ');
        int N, M;

        bool first = Int32.TryParse(arr[0], out N);
        bool second = Int32.TryParse(arr[1], out M);

        int[,] theMatrix = new int[N, M];
        int maxSum = int.MinValue;

        for (int rows = 0; rows < N; rows++)
        {
            string numbers = Console.ReadLine();
            string[] theSplit = numbers.Split(' ');

            for (int col = 0; col < M; col++)
            {
                bool truth = Int32.TryParse(theSplit[col], out theMatrix[rows, col]);   
            }
        }

        for (int row = 0; row < theMatrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < theMatrix.GetLength(1) - 2; col++)
            {
                int sum = theMatrix[row, col] + theMatrix[row + 1, col] + theMatrix[row + 2, col] + theMatrix[row, col + 1] + theMatrix[row, col + 2] + theMatrix[row + 1, col + 1] + theMatrix[row + 1, col + 2] + theMatrix[row + 2, col + 1] + theMatrix[row + 2, col + 2];

                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine("{0}", maxSum);
    }
}