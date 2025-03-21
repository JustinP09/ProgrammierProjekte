using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptfenster.klassen
{
    public class ZeitTafel
    {
        public string Montag { get; set; }
        public string Dienstag { get; set; }
        public string Mittwoch { get; set; }
        public string Donnerstag { get; set; }
        public string Freitag { get; set; }

        //hallo
        public ZeitTafel(string montag, string dienstg, string mittwoch, string donnerstag, string freitag)
        {
            this.Montag = montag;
            this.Dienstag = dienstg;
            this.Mittwoch = mittwoch;
            this.Donnerstag = donnerstag;
            this.Freitag = freitag;
        }
        public ZeitTafel() { }

        public static ObservableCollection<ZeitTafel> StundenPlanZuZeitplan(Stundenplan stundenplan)
        {
            ObservableCollection<ZeitTafel> zeitTafel = new ObservableCollection<ZeitTafel>();
            for (int i = 0; i < stundenplan.uniTage[0].stunden.Count; i++)
            {
                List<string> zeitfeld = new List<string>();
                for (int j = 0; j < stundenplan.uniTage.Count; j++)
                {
                    zeitfeld.Add(stundenplan.uniTage[j].stunden[i].bezeichnung +
                        "\n" + stundenplan.uniTage[j].stunden[i].raum +
                        "\n" + stundenplan.uniTage[j].stunden[i].prof);

                }
                zeitTafel.Add(new ZeitTafel(zeitfeld[0], zeitfeld[1], zeitfeld[2], zeitfeld[3], zeitfeld[4]));
            }
            return zeitTafel;
        }
    }
}
