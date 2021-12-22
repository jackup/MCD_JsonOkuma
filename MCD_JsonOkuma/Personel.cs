using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_JsonOkuma
{
    class Personel
    {
        public Guid ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string sehir { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
