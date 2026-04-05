using System;

namespace tpmodul7_103082400026
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400026 data = new DataMahasiswa103082400026();
            data.ReadJSON();

            Console.ReadLine(); // Menahan layar terminal
        }
    }
}