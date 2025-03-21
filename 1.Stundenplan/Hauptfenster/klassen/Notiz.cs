using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptfenster
{
    public class Notiz
    {
        public string titel { get; set; }
        public string inhalt { get; set; }

        public Notiz() { }
        public Notiz(string _inthalt) { this.inhalt = _inthalt; }
    }
}
