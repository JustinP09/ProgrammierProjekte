using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptfenster
{
    public class Stundenplan
    {
        public ObservableCollection<UniTag> uniTage { get; set; } = new ObservableCollection<UniTag>();
    }
}
