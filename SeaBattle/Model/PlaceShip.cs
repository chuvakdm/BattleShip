using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Model
{
    internal class PlaceShip
    {
        public TypeCell[,] CreateBoardRandom()
        {
            TypeCell[,] board = new TypeCell[10, 10];

            PlaceShip placeShip = new PlaceShip();
            placeShip.ClearBoard(board);

            Ship[] ships = new Ship[]
            {
            new Ship("One Deck", 4, 1),
            new Ship("Two Deck", 3, 2),
            new Ship("Three Deck", 2, 3),
            new Ship("Four Deck", 1, 4)
            };

            foreach (Ship ship in ships)
            {
                board = placeShip.RandomPlaceShip(ship, board);
            }

            return board;
        }



        private TypeCell[,] RandomPlaceShip(Ship ship, TypeCell[,] board)
        {
            bool create = false;
            while (ship.quantity > 0)
            {
                Random randrow = new Random();
                Random randcolumns = new Random();
                Random randhorver = new Random();

                int row = randrow.Next(0, 10);
                int column = randcolumns.Next(0, 10);
                int horOrVer = randhorver.Next(0, 2);

                bool checkCord = CheckAvailability(row, column, ship.size, Convert.ToBoolean(horOrVer), board);

                if (checkCord)
                {

                }
                else
                {
                    continue;
                }

                if (horOrVer == 0)
                {
                    int check = 0;
                    int wor = row;
                    if (row < ship.size)
                    {
                        for (int i = 0; i < ship.size; i++)
                        {
                            if (board[wor, column] == TypeCell.Empty)
                            {
                                check++;
                            }
                            wor++;
                        }
                        if (ship.size == check)
                        {
                            for (int i = 0; i < ship.size; i++)
                            {
                                board[row, column] = TypeCell.isShip;
                                AddNearCells(row, column, board);
                                row++;
                            }

                            check = 0;

                        }
                        create = true;
                        ship.quantity--;
                    }
                    else if (9 - row < ship.size)
                    {
                        for (int i = 0; i < ship.size; i++)
                        {
                            if (board[wor, column] == TypeCell.Empty)
                            {
                                check++;
                            }
                            wor--;
                        }
                        if (ship.size == check)
                        {
                            for (int i = 0; i < ship.size; i++)
                            {
                                board[row, column] = TypeCell.isShip;
                                AddNearCells(row, column, board);
                                row--;
                            }
                            check = 0;

                        }
                        create = true;
                        ship.quantity--;

                    }
                    else if (create);
                    {
                        for (int i = 0; i < ship.size; i++)
                        {
                            if (board[wor, column] == TypeCell.Empty)
                            {
                                check++;
                            }
                            wor--;

                        }
                        if (ship.size == check)
                        {
                            for (int i = 0; i < ship.size; i++)
                            {
                                board[row, column] = TypeCell.isShip;
                                AddNearCells(row, column, board);
                                row++;
                            }
                            check = 0;

                        }
                        ship.quantity--;
                    }
                }
                else if (horOrVer == 1)
                {
                    int col = column;
                    int check = 0;
                    if (column < ship.size)
                    {
                        for (int i = 0; i < ship.size; i++)
                        {
                            if (board[row, col] == TypeCell.Empty)
                            {
                                check++;
                            }
                            col++;
                        }
                        if (ship.size == check)
                        {
                            for (int i = 0; i < ship.size; i++)
                            {
                                board[row, column] = TypeCell.isShip;
                                AddNearCells(row, column, board);
                                column++;
                            }
                            check = 0;

                        }
                        create = true;
                        ship.quantity--;
                    }
                    else if (9 - column < ship.size)
                    {
                        for (int i = 0; i < ship.size; i++)
                        {
                            if (board[row, col] == TypeCell.Empty)
                            {
                                check++;
                            }
                            col--;
                        }
                        if (ship.size == check)
                        {
                            for (int i = 0; i < ship.size; i++)
                            {
                                board[row, column] = TypeCell.isShip;
                                AddNearCells(row, column, board);
                                column--;
                            }
                            check = 0;

                        }
                        create = true;
                        ship.quantity--;
                    }
                    else if (create == true)
                    {
                        for (int i = 0; i < ship.size; i++)
                        {
                            if (board[row, col] == TypeCell.Empty)
                            {
                                check++;
                            }
                            col--;

                        }
                        if (ship.size == check)
                        {
                            for (int i = 0; i < ship.size; i++)
                            {
                                board[row, column] = TypeCell.isShip;
                                AddNearCells(row, column, board);
                                column++;
                            }
                            check = 0;
                        }
                        ship.quantity--;
                    }
                }
            }
            return board;
        }

        public void ClearBoard(TypeCell[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        private void AddNearCells(int row, int col, TypeCell[,] board)
        {

            if (col > 0 && board[row, col - 1] == TypeCell.Empty)
            {
                board[row, col - 1] = TypeCell.Near;
            }
            if (col < 9 && board[row, col + 1] == TypeCell.Empty)
            {
                board[row, col + 1] = TypeCell.Near;
            }
            if (row > 0 && board[row - 1, col] == TypeCell.Empty)
            {
                board[row - 1, col] = TypeCell.Near;
            }
            if (row < 9 && board[row + 1, col] == TypeCell.Empty)
            {
                board[row + 1, col] = TypeCell.Near;
            }
            if (row > 0 && col > 0 && board[row - 1, col - 1] == TypeCell.Empty)
            {
                board[row - 1, col - 1] = TypeCell.Near;
            }
            if (row > 0 && col < 9 && board[row - 1, col + 1] == TypeCell.Empty)
            {
                board[row - 1, col + 1] = TypeCell.Near;
            }
            if (row < 9 && col > 0 && board[row + 1, col - 1] == TypeCell.Empty)
            {
                board[row + 1, col - 1] = TypeCell.Near;
            }
            if (row < 9 && col < 9 && board[row + 1, col + 1] == TypeCell.Empty)
            {
                board[row + 1, col + 1] = TypeCell.Near;
            }
        }

        private bool CheckAvailability(int row, int column, int size, bool isHorizontal, TypeCell[,] board)
        {
            if (isHorizontal)
            {
                if (column + size > board.GetLength(1))
                {
                    return false;
                }

                for (int i = 0; i < size; i++)
                {
                    if (board[row, column + i] != TypeCell.Empty)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (row + size > board.GetLength(0))
                {
                    return false;
                }

                for (int i = 0; i < size; i++)
                {
                    if (board[row + i, column] != TypeCell.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
