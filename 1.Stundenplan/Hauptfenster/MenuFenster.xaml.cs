using Hauptfenster;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Windows.Media;

namespace Hauptfenster
{

    public partial class MenuFenster : Window
    {
        public MenuFenster()
        {
            InitializeComponent();

            // Beispiel: Standard-Seite gleich beim Öffnen
            MainFrame.Navigate(new Page_Stundenplan());
            btnStundenplan.Background = new SolidColorBrush(Colors.LightGreen);

        }

       

        private void BtnStundenplan_Click(object sender, RoutedEventArgs e)
        {
            // aktiven Button einfärben
            ResetButtonStyles();
            btnStundenplan.Background = new SolidColorBrush(Colors.LightGreen);

            MainFrame.Navigate(new Page_Stundenplan());

        }

        private void BtnToDo_Click(object sender, RoutedEventArgs e)
        {
            // aktiven Button einfärben
            ResetButtonStyles();
            btnToDo.Background = new SolidColorBrush(Colors.LightGreen);

            MainFrame.Navigate(new Page_Todo());
        }

        private void BtnNotizen_Click(object sender, RoutedEventArgs e)
        {
            // aktiven Button einfärben
            ResetButtonStyles();
            btnNotizen.Background = new SolidColorBrush(Colors.LightGreen);

            MainFrame.Navigate(new Page_Notizen());
        }

        private void BtnKlausuren_Click(object sender, RoutedEventArgs e)
        {
            // aktiven Button einfärben
            ResetButtonStyles();
            btnKlausuren.Background = new SolidColorBrush(Colors.LightGreen);

            MainFrame.Navigate(new Page_Klausuren());
        }

        private void ResetButtonStyles()
        {
            // Alles neutral oder Standard
            var defaultBrush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)); // Transparent oder LightGray etc.

            btnStundenplan.Background = defaultBrush;
            btnToDo.Background = defaultBrush;
            btnNotizen.Background = defaultBrush;
            btnKlausuren.Background = defaultBrush;
        }
    }
}
