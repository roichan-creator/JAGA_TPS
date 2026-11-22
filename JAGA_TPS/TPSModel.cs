using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGA_TPS
{

    public class TPSModel
    {
        public string Id { get; set; }
        public string NamaTPS { get; set; }
        public string Lokasi { get; set; }

        public int Volume { get; set; }

        public bool SudahDiperiksa { get; set; }

        public string JadwalRutin { get; set; }
    }

}
