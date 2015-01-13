using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
	public class Mines
	{
		public class Points
		{
			string name;
			int points;

			public string name
			{
				get { return name; }
				set { name = value; }
			}

			public int points
			{
				get { return points; }
				set { points = value; }
			}

			public Points() { }

			public Points(string name, int points)
			{
				this.name = name;
				this.points = points;
			}
		}

		static void Main(string[] arguments)
		{
			string command = string.Empty;
			char[,] field = CreateGameField();
			int counter = 0;
			bool explosion = false;
			List<Points> champions = new List<Points>(6);
			int row = 0;
			int column = 0;
			bool flag = true;
			const int MAX = 35;
			bool flag2 = false;

			do
			{
				if (flag)
				{
					Console.WriteLine("Let's play “Minesweeper”. Try your luck in finding fields with no Minesweeper." +
					" command 'top' shows Highscore, 'restart' starts a new game, 'exit' to quit the game.");
					dumpp(field);
					flag = false;
				}
				Console.Write("Enter row and column: ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						PrintHighScore(champions);
						break;
					case "restart":
						field = CreateGameField();
						bombs = PlaceBombs();
						dumpp(field);
						explosion = false;
						flag = false;
						break;
					case "exit":
						Console.WriteLine("Bye-bye!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								UpdateGameField(field, bombs, row, column);
								counter++;
							}
							if (MAX == counter)
							{
								flag2 = true;
							}
							else
							{
								dumpp(field);
							}
						}
						else
						{
							explosion = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Invalid command\n");
						break;
				}
				if (explosion)
				{
					dumpp(bombs);
					Console.Write("\nGrrrrrr! You died heroically with {0} points. " +
						"Enter your nickname: ", counter);
					string nickname = Console.ReadLine();
					Points newPointEntry = new Points(nickname, counter);
					if (champions.Count < 5)
					{
                        champions.Add(newPointEntry);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
                            if (champions[i].points < newPointEntry.points)
							{
                                champions.Insert(i, newPointEntry);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
					champions.Sort((Points r1, Points r2) => r2.name.CompareTo(r1.name));
					champions.Sort((Points r1, Points r2) => r2.points.CompareTo(r1.points));
					PrintHighScore(champions);

					field = CreateGameField();
					bombs = PlaceBombs();
					counter = 0;
					explosion = false;
					flag = true;
				}
				if (flag2)
				{
					Console.WriteLine("\nCongratulations! You revealed 35 cells without loosing any health!");
					dumpp(bombs);
					Console.WriteLine("Please enter your name: ");
					string nameInput = Console.ReadLine();
					Points pointCount = new Points(nameInput, counter);
					champions.Add(pointCount);
					PrintHighScore(champions);
					field = CreateGameField();
					bombs = PlaceBombs();
					counter = 0;
					flag2 = false;
					flag = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria");
			Console.WriteLine("Goodbye!");
			Console.Read();
		}

		private static void PrintList<Points> winners)
		{
			Console.WriteLine("\nPoints:");
            if (winners.Count > 0)
			{
                for (int i = 0; i < winners.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} boxes",
                        i + 1, winners[i].name, winners[i].points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Highscore is empty!\n");
			}
		}

		private static void UpdateGameField(char[,] board,
			char[,] mines, int row, int column)
		{
			char numberOfBombs = CalculateCellValue(BOMBI, row, column);
			mines[row, column] = numberOfBombs;
			board[row, column] = numberOfBombs;
		}

		private static void dumpp(char[,] board)
		{
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceBombs()
		{
			int rows = 5;
			int columns = 10;
			char[,] gameBoard = new char[rows, columns];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					gameBoard[i, j] = '-';
				}
			}

			List<int> mines = new List<int>();
			while (mines.Count < 15)
			{
				Random random = new Random();
				int randomValue = random.Next(50);
				if (!mines.Contains(randomValue))
				{
					mines.Add(randomValue);
				}
			}

			foreach (int mine in mines)
			{
				int col = (mine / columns);
				int row = (mine % columns);
				if (row == 0 && mine != 0)
				{
					col--;
					row = columns;
				}
				else
				{
					row++;
				}
				gameBoard[col, row - 1] = '*';
			}

			return gameBoard;
		}

		private static void PerformCalculation(char[,] board)
		{
			int col = board.GetLength(0);
			int row = board.GetLength(1);

			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (board[i, j] != '*')
					{
						char cellValue = CalculateCellValue(board, i, j);
						board[i, j] = cellValue;
					}
				}
			}
		}

		private static char CalculateCellValue(char[,] field, int row, int col)
		{
			int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
			{
                if (field[rr - 1, col] == '*')
				{ 
					count++; 
				}
			}
            if (row + 1 < rows)
			{
                if (field[row + 1, col] == '*')
				{ 
					count++; 
				}
			}
            if (col - 1 >= 0)
			{
                if (field[row, col - 1] == '*')
				{ 
					count++;
				}
			}
            if (col + 1 < cols)
			{
                if (field[row, col + 1] == '*')
				{ 
					count++;
				}
			}
            if ((row - 1 >= 0) && (col - 1 >= 0))
			{
                if (field[row - 1, col - 1] == '*')
				{ 
					count++; 
				}
			}
            if ((row - 1 >= 0) && (col + 1 < cols))
			{
                if (field[row - 1, col + 1] == '*')
				{ 
					count++; 
				}
			}
            if ((row + 1 < rows) && (col - 1 >= 0))
			{
                if (field[row + 1, col - 1] == '*')
				{ 
					count++; 
				}
			}
            if ((row + 1 < rows) && (col + 1 < cols))
			{
                if (field[row + 1, col + 1] == '*')
				{ 
					count++; 
				}
			}
			return char.Parse(count.ToString());
		}
	}
}
