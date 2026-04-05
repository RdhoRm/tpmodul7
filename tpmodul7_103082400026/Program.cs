using System;

namespace tpmodul7_103082400026
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Pemanggilan Bagian 1 ---
            DataMahasiswa103082400026 data = new DataMahasiswa103082400026();
            data.ReadJSON();

            Console.WriteLine(); // Memberi jarak kosong (Enter)

            // --- Pemanggilan Bagian 2 ---
            KuliahMahasiswa103082400026 kuliah = new KuliahMahasiswa103082400026();
            kuliah.ReadJSON();

            Console.ReadLine(); // Menahan layar terminal
        }
    }
}