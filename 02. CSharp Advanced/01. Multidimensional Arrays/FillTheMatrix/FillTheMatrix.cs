using System;

class Program
{
    static void Main()
    {
        int sizeN = int.Parse(Console.ReadLine());
        int[,] matrix = new int[sizeN,sizeN];
        int count = 1;
        int counter = 0;
        int counting = 1;
        int caseB = sizeN - 1;
        char variant = char.Parse(Console.ReadLine());

        for (int row = 0; row < sizeN; row++)
            {
            for (int col = 0; col < sizeN; col++)
                {
                matrix[row, col] = counter + 1;
                counter++;
                }
            }

        switch (variant)
        {
            case 'a':
                for (int col = 0; col < sizeN; col++)
                {
                    for (int row = 0; row < sizeN; row++)
                    {
                        Console.Write("{0}", matrix[row, col]);
                        if (row == sizeN - 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                   
                }
                break;

            case 'b':
                for (int row = 0; row < sizeN; row++)
                {
                    for (int col = 0; col < sizeN; col++)
                    {
                        if (col == 0 || col % 2 == 0)
                        {
                            Console.Write("{0}", matrix[col, row]);
                            if (col != sizeN - 1)
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            Console.Write("{0}", matrix[col, sizeN- row - 1]);
                            if (col != sizeN -1)
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
                break;

            case 'c':
                int rows = sizeN - 1;
                int cols = 0;
                for (int i = 0; i < sizeN * sizeN; i++)
                {
                    matrix[rows, cols] = count;
                    rows++;
                    cols++;
                    count++;

                    if (rows == sizeN || cols == sizeN)
                    {
                        rows--;
                        if (cols == sizeN)
                        {
                            rows--;
                            cols--;
                        }
                        while (rows - 1 >= 0 && cols - 1 >= 0)
                        {
                            rows--;
                            cols--;
                        }
                    }
                }
                for (int col = 0; col < sizeN; col++)
                {
                    for (int row = 0; row < sizeN; row++)
                    {
                        Console.Write("{0}",matrix[col, row] );
                        if (row != sizeN - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                break;

            case 'd':

                int rowS = 0;
                int colS = 0;
                int maxRows = sizeN - 1;
                int maxCols = sizeN - 1;

                do
                {
                    for (int i = rowS; i <= maxRows; i++)
                    {
                        matrix[i, colS] = counting;
                        counting++;
                    }
                    colS++;

                    for (int i = colS; i <= maxCols; i++)
                    {
                        matrix[maxRows, i] = counting;
                        counting++;
                    }
                    maxRows--;

                    for (int i = maxRows; i >= rowS; i--)
                    {
                        matrix[i, maxCols] = counting;
                        counting++;
                    }
                    maxCols--;

                    for (int i = maxCols; i >= colS; i--)
                    {
                        matrix[rowS, i] = counting;
                        counting++;
                    }
                    rowS++;
                }
                while (counting <= sizeN * sizeN);

                for (int col = 0; col < sizeN; col++)
                {
                    for (int row = 0; row < sizeN; row++)
                    {
                        Console.Write("{0}", matrix[col, row]);
                        if (row != sizeN - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                break;
        }
    }
}
