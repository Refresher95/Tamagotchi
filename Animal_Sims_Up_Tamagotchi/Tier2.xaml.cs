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
using System.Windows.Threading;

namespace Animal_Sims_Up_Tamagotchi
{
    /// <summary>
    /// Interaktionslogik für Tier1.xaml
    /// </summary>
    public partial class Tier2 : Window
    {

        Tierneeds tier = GameManger.delphin;

        DispatcherTimer timertier2 = new DispatcherTimer();

        public Tier2()
        {
            InitializeComponent();


            timertier2.Start();
            timertier2.Interval = TimeSpan.FromMilliseconds(100);
            timertier2.Tick += t_ticker;

        }

        private void t_ticker(object sender, EventArgs e)
        {
            hunger_Anzeige.Value = tier.Hunger_wert;
            hp_Anzeige.Value = tier.Hp_wert;



            // Farbe ändert zu Rot, Gelb oder Grün nach Wert
            //----------------------------------------------------------------------------------------------------------------------------
            //Gelb hunger
            if (hunger_Anzeige.Value <= 75)
            {
                hunger_Anzeige.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            //Rot hunger
            if (hunger_Anzeige.Value <= 50)
            {
                hunger_Anzeige.Foreground = new SolidColorBrush(Colors.Red);
            }
            // Gelb hp
            if (hp_Anzeige.Value <= 75)
            {
                hp_Anzeige.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            //Rot hp
            if (hp_Anzeige.Value <= 50)
            {
                hp_Anzeige.Foreground = new SolidColorBrush(Colors.Red);
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (hunger_Anzeige.Value == 0)
            {
                tier.kuscheln_minus();
            }

            if (hunger_Anzeige.Value > 0)
            {
                tier.fuettern_minus();
            }

            //----------------------------------------------------------------------------------------------------------------------------

            if (hp_Anzeige.Value == 0)
            {
                MessageBoxResult result = MessageBox.Show("PETA meldet Tierquälerei! Delphin ist kaputt!", "Game Over!", MessageBoxButton.OK);
                if (result == MessageBoxResult.OK) Application.Current.Shutdown();
            }
            //----------------------------------------------------------------------------------------------------------------------------
        }
        private void fuetterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (hunger_Anzeige.Value <= 90)
            {
                MessageBoxResult resultoverdose = MessageBox.Show("Delphin ist überfüttert!", "Game Over!", MessageBoxButton.OK);
                if (resultoverdose == MessageBoxResult.OK) Application.Current.Shutdown();
            }
            else
                tier.fuettern_plus();

        }
        private void kuschelnBtn_Click(object sender, RoutedEventArgs e)
        {
            tier.kuscheln_plus();
        }

        private void TierauswahlBtn_Click(object sender, RoutedEventArgs e)
        {
            Tierauswahl tierauswahl = new Tierauswahl();
            tierauswahl.Show();
            Close();
        }
    }
}
