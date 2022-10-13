using System;

namespace Fundamental
{
    class Program
    {
        static void Main()
        {
            //{tpe data} {nama variable} = {nilai variable}

            int x = 10;
            int y = 5;
            string nama = "Sabil";
            int hasil = x+ y;
            Console.WriteLine("Fundamental");
            Console.WriteLine(hasil);
            Console.WriteLine(nama);

            //tipe data

            //untuk menandai float, maka diakhir nilai variabel diakhiri f, jika tidak maka gunakan tipe data double. karena float byte lebih kecil
            float bilbul = 5000.20f;
            string text = "abcdefg";
            string comb = bilbul + text;
            Console.WriteLine(comb);

            bool condition = true;

            //input output

            //input
            int a = Convert.ToInt32(Console.ReadLine());

            //proses
            a = a * 2;

            //output
            Console.WriteLine(a);

            //Converts
            //convertnumber
            string numbinstr = "12345";
            int angka = System.Convert.ToInt32(numbinstr);
            Console.WriteLine(angka);

            //alternate
            int anothernumber = int.Parse(numbinstr);
            Console.WriteLine(anothernumber);

            //another example
            int numbs = 100;
            short numbshort = (short)numbs;
            Console.WriteLine(numbshort);

            //looping

            //{inisiasi awal};{kondisi};{action}
            for(int i = 0; i < 10; i++)
            { 
                Console.WriteLine("Sabil");
                Console.WriteLine(i);
            }




        } 
    }
}