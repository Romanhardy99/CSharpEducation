using System.Security;

namespace HomeTask2
{
    public class Program
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

                    //проверить свободна ли ячейка
                    if (board[row, col] != 'X' && board[row, col] != 'O')
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

        static void SwapPlayer()
        {
            Player = (Player == Player)? Player2 : Player1;
        }

        static bool CheckWin()
        {
            //проверка строк
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == Player && board[i, 1] == Player && board[i, 2] == Player)
                    return true;
            }
            //столбцов
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == Player && board[1, j] == Player && board[2, j] == Player)
                    return true;
            }
            //по диагонали
            if (board[0, 0] == Player && board[1, 1] == Player && board[2, 2] == Player)
                return true;
            if (board[0, 2] == Player && board[1, 1] == Player && board[2, 0] == Player)
                return true;
            return false;
        }
        //проверяю есть ли свободное место на доске 
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


    }
}
