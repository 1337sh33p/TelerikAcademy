using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackyTheSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*input first line = the dimensions of the den
             * on the next C line you will receive the den
             * on the third line you will receive directions*/

            var denDimensions = Console.ReadLine().Split('x').Select(int.Parse).ToArray();
            var rows = denDimensions[0];
            var cols = denDimensions[1];
            char[,] den = new char[rows, cols];
            // fill the den with symbols
            var start = 0;
            for (int i = 0; i < rows; i++)
            {
                var inputForRow = Console.ReadLine();
                for (int j = 0; j < inputForRow.Length; j++)
                {
                    den[i, j] = inputForRow[j];
                    if (den[i, j] == 's')
                    {
                        start = j;
                    }
                }
            }
            //take input for directions

            var directions = Console.ReadLine().Split(',');

            var snackyLength = 3;
            var movesCounter = 0;

            /* . - free space
             * # - rock
             * * - food
             * s - start*/
            var startRow = 0;
            var startCol = start;
            var currentRow = startRow;
            var currentCol = start;
            for (int move = 0; move < directions.Length; move++)
            {
                if (directions[move] == "d")
                {
                    currentRow++;
                }
                else if (directions[move] == "u")
                {
                    currentRow--;
                }
                else if (directions[move] == "l")
                {
                    currentCol--;
                    if (currentCol < 0)
                    {
                        currentCol = cols - 1;
                    }
                }
                else if (directions[move] == "r")
                {
                    currentCol++;
                    if (currentCol > cols - 1)
                    {
                        currentCol = 0;
                    }
                }
                movesCounter++;
                if (movesCounter == 5)
                {
                    snackyLength--;
                    movesCounter = 0;
                }
                if (snackyLength <= 0)
                {
                    Console.WriteLine("Snacky will starve at [{0},{1}]", currentRow, currentCol);
                    break;
                }
                if (den[currentRow, currentCol] == '*')
                {
                    snackyLength++;
                    den[currentRow, currentCol] = '.';
                }
                else if (den[currentRow, currentCol] == '#')
                {
                    Console.WriteLine("Snacky will hit a rock at [{0},{1}]", currentRow, currentCol);
                    break;
                }
                else if (currentRow >= rows - 1)
                {
                    Console.WriteLine("Snacky will be lost into the depths with length {0}", snackyLength);
                    break;
                }
                else if (move == directions.Length-1 && (currentRow != startRow && currentCol != startCol))
                {
                    Console.WriteLine("Snacky will be stuck in the den at [{0},{1}]", currentRow, currentCol);
                }
                else
                {
                    if (currentRow == startRow && currentCol == startCol)
                    {
                        Console.WriteLine("Snacky will get out with length {0}", snackyLength);
                        break;
                    }
                }
            }
        }
    }
}