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

namespace Animal_Sims_Up_Tamagotchi
{
    /// <summary>
    /// Interaktionslogik für Tierauswahl.xaml
    /// </summary>
    public partial class Tierauswahl : Window
    {
        public Tierauswahl()
        {
            InitializeComponent();


        }

        private void Tier1Button_Click(object sender, RoutedEventArgs e)
        {
            Tier1 tier1 = new Tier1();
            tier1.Show();
            Close();
        }

        private void Tier2Button_Click(object sender, RoutedEventArgs e)
        {
            Tier2 tier2 = new Tier2();
            tier2.Show();
            Close();
        }

        private void Tier3Button_Click(object sender, RoutedEventArgs e)
        {
            Tier3 tier3 = new Tier3();
            tier3.Show();
            Close();
        }
    }
}
