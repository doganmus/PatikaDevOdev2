using System;
using System.Collections;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            Console.WriteLine("Sayı Giriniz(20 Adet): ");
            for (int i = 0; i < 20; i++)
            {
                Int32.TryParse(Console.ReadLine(),out int number);
                numbers.Add(number);
            }
            numbers.Sort();
            Console.WriteLine("En Küçük Üç Sayı:{0},{1},{2}",numbers[0],numbers[1],numbers[2]);
            Console.WriteLine("En Büyük Üç Sayı:{0},{1},{2}",numbers[17],numbers[18],numbers[19]);

            Console.WriteLine("En Küçük Üç Sayının Ortalaması: " + (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]) +Convert.ToInt32(numbers[2]))/3);

            Console.WriteLine("En Büyük Üç Sayının Ortalaması: " + (Convert.ToInt32(numbers[17]) + Convert.ToInt32(numbers[18]) +Convert.ToInt32(numbers[19]))/3);

            decimal bigNumbers = (Convert.ToInt32(numbers[17]) + Convert.ToInt32(numbers[18]) +Convert.ToInt32(numbers[19]))/3;
            decimal smallNumbers = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]) +Convert.ToInt32(numbers[2]))/3;
            decimal ort = (bigNumbers + smallNumbers)/2;
            Console.WriteLine("En Küçük ve En Büyük Üç Sayının Toplam Ortalaması: "+ort  );
        }
    }
}
