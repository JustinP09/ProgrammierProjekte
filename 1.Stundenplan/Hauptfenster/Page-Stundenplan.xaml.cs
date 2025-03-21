using Hauptfenster.klassen;
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
    /// Interaktionslogik für Page_Stundenplan.xaml
    /// </summary>
    public partial class Page_Stundenplan : Page
    {
        public ObservableCollection<ZeitTafel> zeitTafel { get; set; } = new ObservableCollection<ZeitTafel>();
        public Stundenplan stundenplan { get; set; } = new Stundenplan();
        //public ObservableCollection<UniTag> stundenplan { get; set; } = new ObservableCollection<UniTag>();

        public Page_Stundenplan()
        {
            //this.DataContext = stundenplan;
            InitializeComponent();
            LeerenStudenPlanErstellen(stundenplan);
            zeitTafel = ZeitTafel.StundenPlanZuZeitplan(stundenplan);
            List<ZeitTafel> speicher = SpeicherReader("stundenplanSpeicher.json");
            zeitTafel = new ObservableCollection<ZeitTafel>(speicher);
            this.DataContext = this;

            // speichert beim wechsel des Fensters
            this.Unloaded += AbspeichernBeimSchliessen;
        }
        public static void LeerenStudenPlanErstellen(Stundenplan stundenplan)
        {
            for (int i = 0; i < 5; i++)
            {
                stundenplan.uniTage.Add(new UniTag());
                stundenplan.uniTage[i].bezeichnung = (TagBezeichnung)i;
                for (int j = 0; j < 6; j++)
                {
                    stundenplan.uniTage[i].stunden.Add(new Stunde());
                    stundenplan.uniTage[i].stunden[j].stundenArt = StundenArt.Freistunde;
                    stundenplan.uniTage[i].stunden[j].bezeichnung = "";
                    stundenplan.uniTage[i].stunden[j].raum = "";
                    stundenplan.uniTage[i].stunden[j].prof = "";
                }
            }
        }

        /* MUSS NEU IMPLEMENTIERT WERDEN
        private void btnKlausuren_Click(object sender, RoutedEventArgs e)
        {
            KlausurenUebersicht kl = new KlausurenUebersicht();
            kl.Show();
        }
        private void btnNotizen_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Notizen();
            AbspeichernBeimSchliessen(sender, e);
        }

        private void btnToDo_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ToDoPage();
            AbspeichernBeimSchliessen(sender, e);
        }
        */

        //Json speicherung
        public static void SpeichernInJson(ObservableCollection<ZeitTafel> zeitTafel, string path)
        {
            string json = JsonSerializer.Serialize(zeitTafel, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);

        }
        public List<ZeitTafel> SpeicherReader(string path)
        {
            if (File.Exists(path) && new FileInfo(path).Length > 0)
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<ZeitTafel>>(json); //Deserialize braucht Parameterlose konstruktoren
            }
            return new List<ZeitTafel>();

        }

        private void AbspeichernBeimSchliessen(object sender, EventArgs e)
        {
            SpeichernInJson(zeitTafel, "stundenplanSpeicher.json");
        }
    }
}