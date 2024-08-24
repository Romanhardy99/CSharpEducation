using System.Security;

namespace HomeTask2
{
    public class TicTacToe
    {
        static char[,] board = new char[3, 3]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        static char Player1 = 'X';
        static char Player2 = 'O';
        static char Player;

        static void Main(string[] args)
        {
            bool game = true;
            Player = Player1;

            while (game)
            {
                DrawBoard();

                PlayerMove();

                if (CheckWin())
                {
                    DrawBoard();

                    Console.WriteLine($"Игрок {Player} победил");

                    game = false;
                }
                else if (BoardFull())
                {
                    DrawBoard();

                    Console.WriteLine("НИЧЬЯ!");

                    game = false;
                }
                else
                {
                    SwapPlayer();
                }
            }
        }
        #region Методы 
        /// <summary>
        /// Отрисовка доски.
        /// </summary>
        static void DrawBoard()
        {
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
                if (i < 2)
                    Console.WriteLine("---------");
            }
        }
        /// <summary>
        /// Проверка хода игрока.
        /// </summary>
        static void PlayerMove()
        {
            bool validmove = false;

            while (!validmove)
            {
                Console.WriteLine($"{Player} введите номер ячейки");

                string input = Console.ReadLine();

                int cell;

                if (int.TryParse(input, out cell) && cell >= 1 && cell <= 9)
                {
                    int row = (cell - 1) / 3;

                    int col = (cell - 1) % 3;

                    if (board[row, col] != 'X' && board[row, col] != 'O') //Проверяем свободна ли ячейка.
                    {
                        board[row, col] = Player;

                        validmove = true;
                    }
                    else
                    {
                        Console.WriteLine("Ячейка занята");
                    }
                }
                else
                {
                    Console.WriteLine("Неккоректный ввод");
                }
            }
        }
        /// <summary>
        /// Смена сторон игроков.
        /// </summary>
        static void SwapPlayer()
        {
            Player = (Player == Player1) ? Player2 : Player1;
        }
        /// <summary>
        /// Проверка игроков на победу.
        /// </summary>
        /// <returns>Возвращает тру если соответствует условию, иначе false.</returns>
        static bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == Player && board[i, 1] == Player && board[i, 2] == Player) //Проверка заполнения строк.
                    return true;
            }

            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == Player && board[1, j] == Player && board[2, j] == Player) //Проверка заполнения столбцов.
                    return true;
            }

            if (board[0, 0] == Player && board[1, 1] == Player && board[2, 2] == Player) //Проверка заполнения по диагонали.
                return true;

            if (board[0, 2] == Player && board[1, 1] == Player && board[2, 0] == Player) //Проверка заполнения по диагонали.
                return true;
            return false;
        }
        /// <summary>
        /// Проверка свободного места на доске.
        /// </summary>
        /// <returns></returns>
        static bool BoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    if (board[i, j] != 'X' && board[i, j] != 'O')
                        return false;
            }
            return true;
        }
        #endregion
    }
}
