using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptfenster
{
    public class KlausurTag : KalenderTag
    {
        public string fach { get; set; }
        public Notiz notiz { get; set; }
        public string raum { get; set; }
        public int anzSpickerSeiten { get; set; }
        public DateTime datum { get; set; }
        public string uhrzeit { get; set; }

        public KlausurTag() { } // Parameterloser Konstruktor
        public KlausurTag(string _fach, string _datum, string _uhrzeit,
                            string _raum, string _anzSpickerSeiten, string _notitz = null)
        {
            this.fach = _fach;
            this.datum = Convert.ToDateTime(_datum);
            this.uhrzeit = _uhrzeit;
            this.raum = _raum;
            this.anzSpickerSeiten = Convert.ToInt32(_anzSpickerSeiten);
            this.notiz = new Notiz(_notitz);
        }
    }
}
