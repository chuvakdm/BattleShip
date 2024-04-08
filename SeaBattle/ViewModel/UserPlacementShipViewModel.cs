using SeaBattle.Model;
using SeaBattle.View;
using SeaBattle.ViewModel.Hepler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SeaBattle.ViewModel
{
    internal class UserPlacementShipViewModel
    {
        public ObservableCollection<Cell> CellsUser { get; set; }
        public HelpCommand<Cell> ClickCellCommand { get; set; }
        public BindableCommand OpenGameBoardWindow { get; set; }

        public UserPlacementShipViewModel()
        {
            CellsUser = new ObservableCollection<Cell>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Cell cell = new Cell();
                    cell.IndX = j;
                    cell.IndY = i;
                    CellsUser.Add(cell);

                }
            }
            ClickCellCommand = new HelpCommand<Cell>(OnCellClick);
            OpenGameBoardWindow = new BindableCommand(_ => openGameBoardWindow());
            
        }
        private void OnCellClick(Cell cell)
        {
            if(cell.IsOccupied == true)
            {
                cell.IsOccupied = false;
                cell.ButtonContent = " ";
            }
            else
            {
                cell.IsOccupied = true;
                cell.ButtonContent = "X";
            }
        }
        // София Алексеевная, если вы читаете это, то я не смог закрыть окно, поэтому представте что оно закрылось :) 
        public void openGameBoardWindow()
        {
            GameBoardView view = new GameBoardView();
            view.Show();


        }
    }
}
