using System;
using System.Collections;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList number = new ArrayList();
            ArrayList pnumber = new ArrayList();
            ArrayList pnumberNo = new ArrayList();
            string entryNum ;
            int control = 0, sum1=0, sum2=0;
            bool ctrl;
            Console.Write("Sayıyı Girin : ");
            for (int i = 0; i < 20; i++){
                entryNum=Console.ReadLine();
                ctrl =int.TryParse(entryNum, out int num);
                if (ctrl && num>0){
                    number.Add(entryNum);
                }
                else{
                    Console.WriteLine("sayısal değer veya pozitif sayı giriniz.");
                    continue;
                }
                
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 2; j < Convert.ToInt32(number[i]); j++)
                {
                    control=1;
                    if (Convert.ToInt32(number[i]) % j == 0){
                        control=0;
                        break;
                    }
                }
                if (control==1){
                    pnumber.Add(number[i]);
                }else{
                    pnumberNo.Add(number[i]);
                }
                
            }
            pnumber.Sort();
            pnumberNo.Sort();
            pnumber.Reverse();
            pnumberNo.Reverse();

            
            Console.WriteLine("Asal Sayılar");
            foreach (var item in pnumber)
            {
                Console.WriteLine(item);
                sum1+=Convert.ToInt32(item);

            }
            Console.WriteLine("Ortalaması: " +Convert.ToDecimal(sum1/pnumber.Count));
            Console.WriteLine("Asal Olmayan Sayılar");
            foreach (var item in pnumberNo)
            {
                Console.WriteLine(item);
                sum2+=Convert.ToInt32(item);
            }
            Console.WriteLine("Ortalaması: " +Convert.ToDecimal(sum2/pnumberNo.Count));
            
        }
    }
}
