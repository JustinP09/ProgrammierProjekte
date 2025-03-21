using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für Page_Todo.xaml
    /// </summary>
    public partial class Page_Todo : Page
    {
        public string toDos { get; set; }
        public Page_Todo()
        {
            InitializeComponent();
            this.DataContext = this;

            // lade Daten aus JSON beim erzeugen
            toDos = SpeicherReader("toDosSpeicher.json");

            // speichert beim wechsel des Fensters
            this.Unloaded += AbspeichernBeimSchliessen;

        }




        //Json speicherung ??? NEUER AUSLÖSER
        public static void SpeichernInJson(string notitzen, string path)
        {
            string json = JsonSerializer.Serialize(notitzen, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);

        }
        public string SpeicherReader(string path)
        {
            if (File.Exists(path) && new FileInfo(path).Length > 0)
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<string>(json); //Deserialize braucht Parameterlose konstruktoren also für KlausurTag und Notiz!
            }
            return "";

        }

        // nicht mehr per Click
        private void AbspeichernBeimSchliessen(object sender, RoutedEventArgs e)
        {
            SpeichernInJson(toDos, "toDosSpeicher.json");
        }
    }
}