using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TagBezeichnung
{
    Montag = 1,
    Dienstag,
    Mittwoch,
    Donnerstag,
    Freitag,
    Samstag,
    Sonntag
}
    
namespace Hauptfenster
{
    public class WochenTag
    {
        public TagBezeichnung bezeichnung;
    }
}
