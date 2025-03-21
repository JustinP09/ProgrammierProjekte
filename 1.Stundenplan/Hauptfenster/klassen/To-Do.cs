using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Dringlichkeit
{
    dringend,
    maessig,
    unwichtig
}
namespace Hauptfenster
{
    public class To_Do
    {
        public string titel;
        public string beschreibung;
        public bool erledigt;
        public Dringlichkeit dringlichkeit;
    }
}
