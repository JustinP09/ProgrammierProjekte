using Hauptfenster.KlausurUebersicht;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace Hauptfenster
{
    /// <summary>
    /// Interaktionslogik für Page_Klausuren.xaml
    /// </summary>
    public partial class Page_Klausuren : Page
    {
        public ObservableCollection<KlausurTag> klausuren { get; set; } = new ObservableCollection<KlausurTag>();

        public Page_Klausuren()
        {
            InitializeComponent();
            this.DataContext = this;
            List<KlausurTag> speicher = SpeicherReader("klausurenSpeicher.json");
            klausuren = new ObservableCollection<KlausurTag>(speicher);

            // speichert beim wechsel des Fensters
            this.Unloaded += AbspeichernBeimSchliessen;
        }
        

        private void KalsurHinzufuegen(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow(this);
            add.ShowDialog();
        }


        private void KlausurLoeschen(object sender, RoutedEventArgs e)
        {
            KlausurTag ausgewaehlteKlausur = dataGrid.SelectedItem as KlausurTag; //Weil SelectedItem kann ja alles sein also bsp Fach, Raum, Uhrzeit,...
            if (ausgewaehlteKlausur != null)
            {
                klausuren.Remove(ausgewaehlteKlausur);
            }
            else
            {
                MessageBox.Show("Fehler!");
            }
        }

        //Json speicherung
        public static void SpeichernInJson(ObservableCollection<KlausurTag> klausuren, string path)
        {
            string json = JsonSerializer.Serialize(klausuren, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);

        }
        public List<KlausurTag> SpeicherReader(string path)
        {
            if (File.Exists(path) && new FileInfo(path).Length > 0)
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<KlausurTag>>(json); //Deserialize braucht Parameterlose konstruktoren also für KlausurTag und Notiz!
            }
            return new List<KlausurTag>();

        }

        private void AbspeichernBeimSchliessen(object sender,EventArgs e)
        {
            SpeichernInJson(klausuren, "klausurenSpeicher.json");
        }
    }
}