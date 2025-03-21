using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum StundenArt
{
    Uebung,
    Vorlesung,
    Tutorium,
    Freistunde
}

namespace Hauptfenster
{
    public class Stunde
    {
        public StundenArt stundenArt;
        public DateTime uhrzeit;
        public string bezeichnung;
        public string prof;
        public string raum;
    }
}
