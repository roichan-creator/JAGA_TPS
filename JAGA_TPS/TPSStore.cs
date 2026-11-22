using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGA_TPS
{
    public static class TPSStore
    {
        // Menyimpan semua TPS yang ditambahkan
        public static List<TPSModel> DaftarTPS =
            new List<TPSModel>();

        // Menyimpan TPS yang sudah diperiksa
        public static List<string> TPSSudahDiperiksa = new List<string>();

        
    }
}
