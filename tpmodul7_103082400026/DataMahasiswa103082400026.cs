using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_103082400026
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class DataMahasiswa103082400026
    {
        public void ReadJSON()
        {
            // Membaca file JSON
            string jsonString = File.ReadAllText("tp7_1_103082400026.json");

            // Proses deserialization
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            // Mencetak hasil
            Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }
}