using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptfenster
{
    public class KalenderTag: WochenTag
    {
        public DateTime datum;
        public List<string> termine;
        public bool freierTag;
    }
}
