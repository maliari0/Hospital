using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Models
{
    public class GirisYapInput
    {
        public string Tc { get; set; }
        public string Sifre { get; set; }
    }
    public class GirisYapResponse
    {
        public bool BasariliMi { get; set; }
        public string Mesaj { get; set; }
    }
}
