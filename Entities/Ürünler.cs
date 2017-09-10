using System;

namespace Entities
{
    public class Ürünler
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public Kategori Kategori { get; set; }
        public int KategoriId { get; set; }

        public Şehir Şehir { get; set; }
        public int ŞehirId { get; set; }
    }
}
