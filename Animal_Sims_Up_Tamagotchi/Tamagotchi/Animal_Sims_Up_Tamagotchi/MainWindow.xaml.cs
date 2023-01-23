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

namespace Animal_Sims_Up_Tamagotchi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            // Code to start a new game
            Tierauswahl tierauswahl = new Tierauswahl();
            tierauswahl.Show();
            Close();
        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            // Code to load a saved game
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            // Code to show options menu
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            // Code to quit the game
            Close();
        }
    }
}
