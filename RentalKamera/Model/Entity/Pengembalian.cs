using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalKamera.Model.Entity
{
    public class Pengembalian
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Kamera { get; set; }
        public string Alat { get; set; }
        public DateTime TanggalPeminjaman { get; set; }
        public DateTime TanggalPengembalian { get; set; }
        public int HariPeminjaman { get; set; }
        public string Total { get; set; }
    }

}
