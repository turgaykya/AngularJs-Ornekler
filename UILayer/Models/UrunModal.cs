using Entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UILayer.Models
{
    public class UrunModal
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public int KategoriId { get; set; }

        public int sehirId { get; set; }
    }
}