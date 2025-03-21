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
using System.Text.Json;
using System.IO;

namespace Hauptfenster.KlausurUebersicht
{
    /// <summary>
    /// Interaktionslogik für AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        // alt: KlausurenUebersicht klausurUebersicht;
        private Page_Klausuren _pageKlausuren;

        // alt: public AddWindow(KlausurenUebersicht _klausurUebersicht)
        public AddWindow(Page_Klausuren pageKlausuren)
        {
            InitializeComponent();

            // alt: this.klausurUebersicht = _klausurUebersicht;
            this._pageKlausuren = pageKlausuren;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KlausurTag kt = new KlausurTag(tbFach.Text, tbDatum.Text, tbUhrzeit.Text, tbRaum.Text, tbSpicker.Text, tbNotitz.Text);

            // alt klausurUebersicht.klausuren.Add(kt);
            _pageKlausuren.klausuren.Add(kt);

            this.Close();

        }
    }
}
