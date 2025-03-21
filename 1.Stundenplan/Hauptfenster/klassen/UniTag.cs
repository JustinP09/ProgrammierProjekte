using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptfenster
{
    public class UniTag:WochenTag
    {
        public ObservableCollection<Stunde> stunden { get; set; } = new ObservableCollection<Stunde>();
    }
}
