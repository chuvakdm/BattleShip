using SeaBattle.ViewModel.Hepler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Model
{
    public class Cell : BindingHelper
    {
        private bool isShip { get; set; }

        private int indX { get; set; }
        private int indY { get; set; }
        private int index {  get; set; }
        private bool isOccupied { get; set; }
        private string buttonContent { get; set; }
        public bool IsOccupied
        {
            get { return isOccupied; }
            set
            {
                isOccupied = value;
                OnPropertyChanged();
            }
        }
        public int IndY
        {
            get { return indY; }
            set 
            {
                indY = value;
                OnPropertyChanged();
            }
        }
        public int IndX
        {
            get { return indX; }
            set
            {
                indX = value;
                OnPropertyChanged();
            }
        }
        public string ButtonContent
        {
            get { return buttonContent; }
            set
            {
                buttonContent = value;
                OnPropertyChanged();
            }
        }
        public bool IsShip
        {
            get { return isShip; }
            set
            {
                isShip = value;
                OnPropertyChanged();
            }
        }
        public int Index
        {
            get { return index; }
            set
            {
                index = value;
                OnPropertyChanged();
            }
        }
    }

    public enum TypeCell
    {
        isShip = 2,
        Near = 1,
        Empty = 0
    }

}
