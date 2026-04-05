using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace tpmodul7_103082400026
{
    public class MataKuliah
    {
        public string kode { get; set; }
        public string nama { get; set; }
    }

    public class DaftarKuliah
    {
        public List<MataKuliah> mata_kuliah { get; set; }
    }

    public class KuliahMahasiswa103082400026
    {
        public void ReadJSON()
        {
            // Membaca file JSON kedua
            string jsonString = File.ReadAllText("tp7_2_103082400026.json");

            // Proses deserialization
            DaftarKuliah kuliah = JsonSerializer.Deserialize<DaftarKuliah>(jsonString);

            // Mencetak hasil sesuai format soal
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in kuliah.mata_kuliah)
            {
                Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
                i++;
            }
        }
    }
}