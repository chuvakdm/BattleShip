using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SeaBattle.Model
{
    internal class Ship
    {
        public string typeShip {  get; set; }
        public int quantity { get; set; }
        public int size { get; set; }

        public Ship(string typeShip, int quantity,int size)
        {
            this.typeShip = typeShip;
            this.quantity = quantity;
            this.size = size;
        }
    }
}
