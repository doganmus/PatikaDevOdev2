using System;
using System.Collections;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("Cümle giriniz: ");
            sentence = Console.ReadLine().ToLower();
            ArrayList vowels = new ArrayList();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]=='a'){
                    vowels.Add(sentence[i]);
                }else if (sentence[i]=='e'){
                    vowels.Add(sentence[i]);
                }else if (sentence[i]=='ı'){
                    vowels.Add(sentence[i]);
                }else if (sentence[i]=='i'){
                    vowels.Add(sentence[i]);
                }else if (sentence[i]=='u'){
                    vowels.Add(sentence[i]);
                }else if (sentence[i]=='ü'){
                    vowels.Add(sentence[i]);
                }else if (sentence[i]=='o'){
                    vowels.Add(sentence[i]);
                }else if (sentence[i]=='ö'){
                    vowels.Add(sentence[i]);
                }
            }
            vowels.Sort();
            foreach (var item in vowels)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
