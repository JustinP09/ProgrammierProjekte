using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptfenster
{
    public class KalenderWoche: Woche
    {
        public int kalenderWoche;
        public KalenderTag[] kalenderTag = new KalenderTag[7];
    }
}
