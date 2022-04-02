using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_1
{
    internal class DataMahasiswa1302200089
    {
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:/Users/Panji/Documents/VS Community things/JurnalMod6/Praktikum_Mod6/modul6_kelompok_1/modul6_kelompok_1/jurnal6_1_1302200089.json");

            dynamic mhs = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Nama: " + mhs.firstName + mhs.lastName);
            Console.WriteLine("Gender: " + mhs.gender);
            Console.WriteLine("Age: " + mhs.age);
            Console.WriteLine("Alamat: " + mhs.address.streetAddress);
            Console.WriteLine("City: " + mhs.address.city);
            Console.WriteLine("State: " + mhs.address.state);

            foreach (var item in mhs.courses)
            {
                Console.WriteLine(item.code);
                Console.WriteLine(item.name);
            }


        }
    }
}
