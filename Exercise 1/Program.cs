using System;

namespace Project_exercise
{
    class project
    {
        // deklarasi array int dengan ukuran 97
        private int[] hamam = new int[97];

        // deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi / method untuk menerima masukkan
        public void read()
        {
            // menerima angka untuk menentukan banyak data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan Berapa banyak elemen array: ");
                string j = Console.ReadLine();
                n = Int32.Parse(j);
                if (n <= 97)
                    break;
                else
                    Console.WriteLine("\nArray maksimal 97 elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Masukkan elemen");
            Console.WriteLine("-----------------------");

            //Pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string m = Console.ReadLine();
                hamam[i] = Int32.Parse(m);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Susunan element array yang benar");
            Console.WriteLine("--------------------------------");
            for (int hp = 0; hp < n; hp++)
            {
                Console.WriteLine(hamam[hp]);
            }
            Console.WriteLine("");
        }
        public void Bubblesort()
        {
            for (int i = 1; i < n; i++) //for n - 1 passaes
            {
                // pada pass i, bandingkan n - 1 eleman pertama dengan elemen selanjutnya
                for (int hp = 0; hp < n - 1; hp++)
                {
                    
                    if (hamam[hp] < hamam[hp + 1])// Jika elemen tidak dalam urutan yang benar 
                    {
                        // Tukar elemen
                        int temp;
                        temp = hamam[hp];
                        hamam[hp] = hamam[hp + 1];
                        hamam[hp + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            project myList = new project();
            myList.read();
            myList.Bubblesort();
            myList.display();

            Console.WriteLine("\n\nTekan Tombol Apa saja untuk keluar.");
            Console.Read();
        }
    }
}