using System;
using System.Windows;

namespace AplikacjaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random randomNumber;
        private int correctNumber;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            randomNumber = new Random();
            correctNumber = randomNumber.Next(1, 11);

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // This function does nothing.
        }

        private void Button_guess_Click(object sender, RoutedEventArgs e)
        {
            int guess = Convert.ToInt32(NumbersList.Text);

            if (guess > correctNumber)
            {
                MessageBox.Show("Podano ZA DUŻĄ liczbę, spróbuj ponownie!");
            }
            else if (guess < correctNumber)
            {
                MessageBox.Show("Podano ZA MAŁĄ liczbę, spróbuj ponownie!");
            }
            else
            {
                MessageBox.Show("BRAWO! Podano właściwą liczbę! Zagrajmy jeszcze raz!");
                NewGame();
            }
        }

        private void Button_exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
