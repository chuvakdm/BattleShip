using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SeaBattle.ViewModel.Hepler
{
    public class MegaMedia
    {
        private MediaPlayer mediaPlayer;

        public void InitializeMediaPlayer()
        {
            mediaPlayer = new MediaPlayer();
            mediaPlayer.MediaEnded += MediaEndedHandler;
            mediaPlayer.Open(new Uri("C:\\Users\\user\\source\\repos\\SeaBattle\\SeaBattle\\Media\\Музыка из пиратов карибского моря (256  kbps).mp3", UriKind.Relative)); // Укажите путь к вашему музыкальному файлу
            mediaPlayer.Play();
        }

        public void MediaEndedHandler(object sender, EventArgs e)
        {
            mediaPlayer.Position = TimeSpan.Zero;
            mediaPlayer.Play();
        }
    }

}
