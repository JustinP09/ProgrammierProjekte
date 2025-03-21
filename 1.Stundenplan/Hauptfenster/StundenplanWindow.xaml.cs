using Hauptfenster.klassen;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace Hauptfenster
{
    /// <summary>
    /// Interaction logic for StundenplanWindow.xaml
    /// </summary>
    public partial class StundenplanWindow : Window
    {
       

        public ObservableCollection<ZeitTafel> zeitTafel { get; set; } = new ObservableCollection<ZeitTafel>();
        public Stundenplan stundenplan { get; set; } = new Stundenplan();
        //public ObservableCollection<UniTag> stundenplan { get; set; } = new ObservableCollection<UniTag>();
        public StundenplanWindow()
        {

            
            LeerenStudenPlanErstellen(stundenplan);

            stundenplan.uniTage[0].stunden[0].bezeichnung = "Mathe";
            stundenplan.uniTage[0].stunden[0].raum = "HQ105";
            stundenplan.uniTage[0].stunden[0].prof = "Scherr";
            stundenplan.uniTage[0].stunden[0].stundenArt = StundenArt.Vorlesung;

            stundenplan.uniTage[1].stunden[1].bezeichnung = "SE";
            stundenplan.uniTage[1].stunden[1].raum = "HQ300";
            stundenplan.uniTage[1].stunden[1].prof = "Meitner";
            stundenplan.uniTage[1].stunden[1].stundenArt = StundenArt.Vorlesung;


            stundenplan.uniTage[2].stunden[2].bezeichnung = "SE";
            stundenplan.uniTage[2].stunden[2].raum = "HQ300";
            stundenplan.uniTage[2].stunden[2].prof = "Kröhner";
            stundenplan.uniTage[2].stunden[2].stundenArt = StundenArt.Uebung;



            stundenplan.uniTage[4].stunden[3].bezeichnung = "SE";
            stundenplan.uniTage[4].stunden[3].raum = "HQ300";
            stundenplan.uniTage[4].stunden[3].prof = "Meitner";
            stundenplan.uniTage[4].stunden[3].stundenArt = StundenArt.Vorlesung;

            stundenplan.uniTage[4].stunden[4].bezeichnung = "SE";
            stundenplan.uniTage[4].stunden[4].raum = "HQ300";
            stundenplan.uniTage[4].stunden[4].prof = "Meitner";
            stundenplan.uniTage[4].stunden[4].stundenArt = StundenArt.Vorlesung;

            zeitTafel = ZeitTafel.StundenPlanZuZeitplan(stundenplan);

            InitializeComponent();

            dgStundenplan.ItemsSource = zeitTafel;
            

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
                    stundenplan.uniTage[i].stunden[j].bezeichnung = " ";
                    stundenplan.uniTage[i].stunden[j].raum = " ";
                    stundenplan.uniTage[i].stunden[j].prof = " ";
                }
            }
        }

        

        //public static void GridFuellen(ref DataGrid dataGrid, Stundenplan stundenplan)
        //{
        //    DataColumn data = new DataColumn();
        //    dataGrid.Columns.Add(colu);
        //}
    }
}
