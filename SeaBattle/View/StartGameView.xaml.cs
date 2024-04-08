using SeaBattle.ViewModel;
using SeaBattle.ViewModel.Hepler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SeaBattle.View
{
    /// <summary>
    /// Логика взаимодействия для StartGameView.xaml
    /// </summary>
    public partial class StartGameView : Window
    {
        public StartGameView()
        {
            InitializeComponent();
            DataContext = new StartGameViewModel();
            StartGameViewModel startGameViewModel = new StartGameViewModel();

            Task.Run(() =>
            {
                MegaMedia mega = new MegaMedia();
                mega.InitializeMediaPlayer();
            });
        }

    }
}
