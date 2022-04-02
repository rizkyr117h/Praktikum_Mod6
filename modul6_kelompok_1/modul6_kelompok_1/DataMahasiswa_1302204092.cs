using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_1
{
    internal class DataMahasiswa_1302204092
    {
        public void ReadJSON()
        {
            //baca file JSON
            String jsonString = File.ReadAllText("C:/Users/ASUS/Documents/SE4401/Semester 4/Konstruksi Perangkat Lunak/W6/Praktikum/Jurnal/Praktikum_Mod6/modul6_kelompok_1/modul6_kelompok_1/jurnal6_1_1302204092");

            //Deserialisasi menjadi objek
            dynamic input = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("Nama: " + input.firstName + input.lastName);
            Console.WriteLine("Jenis Kelamin: " + input.gender);
            Console.WriteLine("Umur: " + input.age);
            Console.WriteLine("Alamat: " + input.address.streetAddress + input.address.city + input.address.state);
            Console.WriteLine("Mata Kuliah: ");
            foreach (var item in input.courses)
            {
                Console.Write("Kode Kelas: " + item.code + ", ");
                Console.WriteLine("Nama Kelas: " + item.name);
            }
        }
    }
}
