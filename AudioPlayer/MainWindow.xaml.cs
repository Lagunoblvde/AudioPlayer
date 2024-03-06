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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AudioPlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            media.Play();
            media.Volume = 0.7;
        }

        private void audio_Player_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            media.Position = new TimeSpan(Convert.ToInt64(audio_Player.Value));
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            audio_Player.Maximum = media.NaturalDuration.TimeSpan.Ticks;
        }

        private void povtor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vpered_Click(object sender, RoutedEventArgs e)
        {

        }

        private void randomno_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
