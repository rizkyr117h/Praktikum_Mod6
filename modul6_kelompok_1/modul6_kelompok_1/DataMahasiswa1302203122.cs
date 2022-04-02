using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_1
{
    internal class DataMahasiswa1302203122
    {
        public static void ReadJson()
        {
            string jsonString = File.ReadAllText("C:/SEMESTER 4/KONSTRUKSI PERANGKAT LUNAK/Praktikum6/modul6_kelompok_1/modul6_kelompok_1/jurnal6_1_1302203122.json");
            dynamic data = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine(data.firstName);
            Console.WriteLine(data.lastName);
            Console.WriteLine(data.gender);
            Console.WriteLine(data.age);
            Console.WriteLine(data.address.streetAddress);
            Console.WriteLine(data.address.city);
            Console.WriteLine(data.address.state);
            foreach(var item in data.courses)
            {
                Console.WriteLine(item.code);
                Console.WriteLine(item.name);
            }
        }

    }
}
