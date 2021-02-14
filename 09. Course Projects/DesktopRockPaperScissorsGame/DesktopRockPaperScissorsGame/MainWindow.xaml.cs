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

namespace DesktopRockPaperScissorsGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRestart_Click(object sender, RoutedEventArgs e)
        {
            TextBoxPlayerResult.Text = "0";
            TextBoxComputerResult.Text = "0";

            MakeAllBordersTransparent();
        }

        private void ImagePlayerRock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MakeAllBordersTransparent();

            int result = new Random().Next(1, 4);

            switch (result)
            {
                case 1:
                    BorderPlayerRock.Background = Brushes.Green;
                    BorderComputerScissors.Background = Brushes.Red;
                    TextBoxPlayerResult.Text = (int.Parse(TextBoxPlayerResult.Text) + 1).ToString();
                    break;

                case 2:
                    BorderPlayerRock.Background = Brushes.Yellow;
                    BorderComputerRock.Background = Brushes.Yellow;
                    break;

                case 3:
                    BorderPlayerRock.Background = Brushes.Red;
                    BorderComputerPaper.Background = Brushes.Green;
                    TextBoxComputerResult.Text = (int.Parse(TextBoxComputerResult.Text) + 1).ToString();
                    break;
            }
        }

        private void ImagePlayerPaper_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MakeAllBordersTransparent();

            int result = new Random().Next(1, 4);

            switch (result)
            {
                case 1:
                    BorderPlayerPaper.Background = Brushes.Green;
                    BorderComputerRock.Background = Brushes.Red;
                    TextBoxPlayerResult.Text = (int.Parse(TextBoxPlayerResult.Text) + 1).ToString();
                    break;

                case 2:
                    BorderPlayerPaper.Background = Brushes.Yellow;
                    BorderComputerPaper.Background = Brushes.Yellow;
                    break;

                case 3:
                    BorderPlayerPaper.Background = Brushes.Red;
                    BorderComputerScissors.Background = Brushes.Green;
                    TextBoxComputerResult.Text = (int.Parse(TextBoxComputerResult.Text) + 1).ToString();
                    break;
            }
        }

        private void ImagePlayerScissors_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MakeAllBordersTransparent();

            int result = new Random().Next(1, 4);

            switch (result)
            {
                case 1:
                    BorderPlayerScissors.Background = Brushes.Green;
                    BorderComputerPaper.Background = Brushes.Red;
                    TextBoxPlayerResult.Text = (int.Parse(TextBoxPlayerResult.Text) + 1).ToString();
                    break;

                case 2:
                    BorderPlayerScissors.Background = Brushes.Yellow;
                    BorderComputerScissors.Background = Brushes.Yellow;
                    break;

                case 3:
                    BorderPlayerScissors.Background = Brushes.Red;
                    BorderComputerRock.Background = Brushes.Green;
                    TextBoxComputerResult.Text = (int.Parse(TextBoxComputerResult.Text) + 1).ToString();
                    break;
            }
        }

        private void MakeAllBordersTransparent()
        {
            BorderPlayerRock.Background = Brushes.Transparent;
            BorderPlayerPaper.Background = Brushes.Transparent;
            BorderPlayerScissors.Background = Brushes.Transparent;

            BorderComputerRock.Background = Brushes.Transparent;
            BorderComputerPaper.Background = Brushes.Transparent;
            BorderComputerScissors.Background = Brushes.Transparent;
        }
    }
}
