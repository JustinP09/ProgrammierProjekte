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
using System.Windows.Shapes;

namespace Hauptfenster
{
    /// <summary>
    /// Interaktionslogik für Page_Notizen.xaml
    /// </summary>
    public partial class Page_Notizen : Page
    {
        public string notitzen { get; set; }
        public Page_Notizen()
        {
            InitializeComponent();
            this.DataContext = this;
            notitzen = SpeicherReader("notitzenSpeicher.json");

            // speichert beim wechsel des Fensters
            this.Unloaded += AbspeichernBeimSchliessen;
        }



        //Json speicherung
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

        private void AbspeichernBeimSchliessen(object sender, EventArgs e)
        {
            SpeichernInJson(notitzen, "notitzenSpeicher.json");
        }
    }
}