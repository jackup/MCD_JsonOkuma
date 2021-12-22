using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_JsonOkuma
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonOkunanData = File.ReadAllText("c:\\Jsonİşlemlerim\\Personellerim.json");
            List<Personel> data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(jsonOkunanData);

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
