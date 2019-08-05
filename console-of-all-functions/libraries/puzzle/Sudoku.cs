using System;
using System.Collections.Generic;
using System.Linq;

namespace console_of_all_functions.libraries.puzzle
{
    class Sudoku
    {
        internal static void Solve(string numbers)
        {
            char[,] board = new char[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = numbers.First();
                    numbers = numbers.Remove(0, 1);
                }
            }

            SolveBoard(board, 0, 0);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j]);
                    if (j % 3 == 2 & j != 8) Console.Write("█");
                }
                Console.Write('\n');
                if (i % 3 == 2 & i!=8)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        Console.Write("█");
                    }
                    Console.Write('\n');
                }
            }
        }

        private static bool SolveBoard(char[,] board, int row, int col)
        {
            if (row > 8)
            {
                return true;
            }

            var visit = board[row, col];
            var isDot = visit == '0';

            var nextRow = col == 8 ? (row + 1) : row;
            var nextCol = col == 8 ? 0 : (col + 1);

            if (!isDot)
            {
                return SolveBoard(board, nextRow, nextCol);
            }

            var availableNumbers = getAvailableNumbers(board, row, col);

            foreach (var option in availableNumbers)
            {
                board[row, col] = option;

                var result = SolveBoard(board, nextRow, nextCol);

                if (result)
                {
                    return true;
                }

                board[row, col] = '0';
            }

            return false;
        }

        private static HashSet<Char> getAvailableNumbers(char[,] board, int currentRow, int currentCol)
        {
            var numbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var available = new HashSet<char>(numbers);

            for (int col = 0; col < 9; col++)
            {
                var visit = board[currentRow, col];
                var isDigit = visit != '.';

                if (isDigit)
                {
                    available.Remove(visit);
                }
            }

            for (int row = 0; row < 9; row++)
            {
                var visit = board[row, currentCol];
                var isDigit = visit != '.';

                if (isDigit)
                {
                    available.Remove(visit);
                }
            }

            var startRow = currentRow / 3 * 3;
            var startCol = currentCol / 3 * 3;
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    var visit = board[row, col];
                    var isDigit = visit != '.';

                    if (isDigit)
                    {
                        available.Remove(visit);
                    }
                }
            }

            return available;
        }

        internal static void Explanation()
        {
            Console.WriteLine("Sudoku is a japanese puzzle game where you need to fit the numbers 1 to 9 in a 9x9 grid, with 9 3x3 squares. " +
                "The numbers must be placed uniquely into the rows, columns and the 3x3 squares without repeting. To solve a puzzle with " +
                "the Solve function, you need to write the numbers as you would read them, from left to right, up to down, replacing empty spaces with 0.");
        }
    }
}
