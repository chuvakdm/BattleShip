using SeaBattle.Model;
using SeaBattle.ViewModel.Hepler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SeaBattle.ViewModel
{
    public class GameBoardViewModel : BindingHelper
    {
        public ObservableCollection<Cell> CellsBot { get; set; }
        public ObservableCollection<Cell> CellsUser { get; set; }

        public HelpCommand<Cell> ClickCellCommand { get; set; }

        public GameBoardViewModel()
        {
            PlaceShip placeShip = new PlaceShip();
            TypeCell[,] typeCell = placeShip.CreateBoardRandom();

            CellsBot = new ObservableCollection<Cell>();
            
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    TypeCell type = typeCell[i,j];
                    Cell cell = new Cell();
                    if(type == TypeCell.isShip)
                    {
                        cell.IsShip = true;
                    }
                    cell.IndX = j;
                    cell.IndY = i;
                    CellsBot.Add(cell);

                }
            }
            
            ClickCellCommand = new HelpCommand<Cell>(OnCellClick);

        }
        private void OnCellClick(Cell cell)
        {
            if(cell.IsShip == true)
            {
                cell.IsOccupied = true;
                cell.ButtonContent = "X";
            }
            else
            {
                cell.IsOccupied = false;
                cell.ButtonContent = "#";
            }


        }


    }
}
