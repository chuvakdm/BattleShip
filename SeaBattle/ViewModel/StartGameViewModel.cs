using SeaBattle.Model;
using SeaBattle.View;
using SeaBattle.ViewModel.Hepler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SeaBattle.ViewModel
{
    internal class StartGameViewModel : BindingHelper
    {
        public bool CloseWindow;
        public BindableCommand OpenGameWindow { get; set; }

        public StartGameViewModel()
        {
            OpenGameWindow = new BindableCommand(_ => openGameWindow());
        }

        public void openGameWindow()
        {

            UserPlacementShipView view = new UserPlacementShipView();
            view.Show();
            Application.Current.MainWindow.Close();
        }
    }
}
