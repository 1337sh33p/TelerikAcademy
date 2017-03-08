using System;
using System.Linq;

class LoverOfThree
{
    static bool IsInsideTheMatrix(int row, int col, bool[,]matrix)
    {
        bool rowIsInsideMatrix = 0 <= row && row <= matrix.GetLength(0) - 1;
        bool colIsInsideMatrix = 0 <= col && col <= matrix.GetLength(1) - 1;
        return rowIsInsideMatrix && colIsInsideMatrix;
    }

    static void Main()
    {
      //input
        //the size of the matrix

        var theMatrixSize = Console.ReadLine()
                            .Split(' ');
        var rowsOfMatrix = int.Parse(theMatrixSize[0]);
        var colsOfMatrix = int.Parse(theMatrixSize[1]);

        //create a bool matrix so that we can mark if we have been to a given block

        var theMatrix = new bool[rowsOfMatrix, colsOfMatrix];

        //the number of directions

        var numberOfMoves = int.Parse(Console.ReadLine());

        //logic
        long sumOfMoves = 0;
        var startingRow = rowsOfMatrix - 1;
        var startingCol = 0;
        var valueOfBlock = 0;

        for (int move = 1; move <= numberOfMoves; move++)
        {
            //read instruction and split it to directions UD RL and number of times to repeat the direction

            var instructions = Console.ReadLine()
                               .Split(' ');
            var direction = instructions[0];
            var numberOfTimes = int.Parse(instructions[1]);

            //check what is the direction

            var rowDirection = direction.Contains("D") ? 1 : -1;
            var colDirection = direction.Contains("R") ? 1 : -1;

            /*for each time check if it is inside the matrix and add the value of 
            the block if it hasn't been visited */

            for (int instance = 1; instance <  numberOfTimes; instance++)
            {
                if (IsInsideTheMatrix(startingRow+rowDirection,startingCol+colDirection, theMatrix))
                {
                    //determine the position of the next block
                    startingRow += rowDirection;
                    startingCol += colDirection;
                    //if the position is down and left decrease the value of the block by 6
                    if (rowDirection == 1 && colDirection == -1)
                    {
                        valueOfBlock -= 6;
                    }
                    //otherwise if the position is up and right increase the value of the block by 6
                    else if (rowDirection == -1 && colDirection == 1)
                    {
                        valueOfBlock += 6;
                    }
                    //checks if the block hasn't been visited and adds its value if true
                    if (!theMatrix[startingRow,startingCol])
                    {
                        sumOfMoves += valueOfBlock;
                        theMatrix[startingRow, startingCol] = true;
                    }
                }
                //breaks the loop if the value is outside the matrix and continues with the next direction
                else
                {
                    break;
                }
            }
        }
        //output
        Console.WriteLine(sumOfMoves);

    }
}