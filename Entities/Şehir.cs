using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Şehir
    {
        public Şehir()
        {
            Ürünler = new HashSet<Ürünler>();
        }
        public int Id { get; set; }
        public string Ad { get; set; }

        public ICollection<Ürünler> Ürünler { get; set; }
    }
}
