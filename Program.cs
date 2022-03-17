using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    using System;

    class Program
    {
        static double tambah(double a, double b)
        {

            return (a + b);
        }

        static double kurang(double a, double b)
        {
            return (a - b);
        }

        static double kali(double a, double b)
        {
            return (a * b);
        }

        static double bagi(double a, double b)
        {
            return (a / b);
        }

        static void Main()
        {
            Menu:

            double bil1, bil2;
            char pilihan;
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |	Program Kalkulator Sederhana	|");
            Console.WriteLine(" ========================================");
            Console.WriteLine("\n");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |	     Masukan Pilihan		");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |	                                |");
            Console.WriteLine(" |	(A) Penambahan                  |");
            Console.WriteLine(" |	(B) pengurangan                 |");
            Console.WriteLine(" |	(C) Perkalian                   |");
            Console.WriteLine(" |	(D) Pembagian                   |");
            Console.WriteLine(" |                                      |");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" Masukan Pilihan		: ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Clear();

            if (pilihan == 'A' || pilihan == 'a')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		|");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah :" + tambah(bil1, bil2) + "|");
                Console.WriteLine(" ========================================");

            }

            else if (pilihan == 'B' || pilihan == 'b')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		|");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah :" + kurang(bil1, bil2) + "|");
                Console.WriteLine(" ========================================");
            }

            else if (pilihan == 'c' || pilihan == 'C')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		|");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah :" + kali(bil1, bil2) + "2|");
                Console.WriteLine(" ========================================");

            }

            else if (pilihan == 'D' || pilihan == 'd')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		|"); 
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" |					|");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah :" + bagi(bil1, bil2) + "|");
                Console.WriteLine(" ========================================");
            }
            else
            {
                Console.WriteLine(" Variabel Yang anda masukkan Salah");
                goto Menu;
                
            }
            Console.ReadKey();
        }
    }
}