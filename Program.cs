using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {          
         Soru_1();   
         Soru_2();   
         Soru_3();   
         Soru_4();   
        
        }

        public static void Soru_1()
        {
            Islemler instance = new();
            
            int n = instance.IsItPositive("Lütfen bir sayi girin: ");
            System.Console.WriteLine();
            int[] numbers = new int[n];
            System.Console.WriteLine($"Lütfen {n} adet pozitif sayi girin! ");

            for (int i = 0; i < numbers.Length; ++i)
            {   
                int n1 = instance.IsItPositive($"Lütfen {i+1}. sayiyi girin: ");
                numbers[i] = n1;
            }

            foreach (int item in numbers)
            {
                if(item % 2 == 0)
                    System.Console.WriteLine($"{item} ");
            }
        }

        public static void Soru_2()
        {
            Islemler instance = new();
            
            int n = instance.IsItPositive("Lütfen bir sayi girin: ");
            int m = instance.IsItPositive("Lütfen bir sayi girin: ");
            int[] numbers = new int[n];
            System.Console.WriteLine();
            System.Console.WriteLine($"Lütfen {n} adet pozitif sayi girin! ");

            for (int i = 0; i < numbers.Length; ++i)
            {   
                int n1 = instance.IsItPositive($"Lütfen {i+1}. sayıyı girin: ");
                numbers[i] = n1;
            }
            foreach (int item in numbers)
            {
                if(item == m || item % m == 0)
                    System.Console.WriteLine($"{item} ");
            }
        }

        public static void Soru_3()
        {
            Islemler instance = new();
            
            int n = instance.IsItPositive("Lütfen bir sayı girin: ");
            string[] words = new string[n];

            System.Console.WriteLine($"Lütfen {n} adet pozitif sayi girin! ");

            for (int i = 0; i < words.Length; ++i)
            {   
                string s = instance.GetWord($"Lütfen {i+1}. kelimeyi girin: ");
                words[i] = s;
            }
            Array.Reverse(words);
            foreach (string item in words)
            {  
                System.Console.Write($"{item}, ");                
            }
           
        }

        public static void Soru_4()
        {
            Islemler instance = new();

            string sentence = instance.GetWord("Lütfen bir cümle girin: ") ;
            string list = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] words = sentence.Split(' ');
            Console.WriteLine($"Toplam {words.Length} adet kelime bulunmaktadır.");

            int counter = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (list.Contains(sentence[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine($"Toplam {counter} adet harf vardır.");
            Console.ReadLine();
        }
    
    }

    class Islemler
    {
        public int IsItPositive(string text)
        {   
            int n;
            bool result;
            do
            {
                System.Console.Write(text);
                n = int.Parse(Console.ReadLine());
                if (n >=0)
                    result = false;
                else
                {
                    System.Console.WriteLine("Lütfen pozitif bir sayı girin!");
                    result = true;
                }

            } while (result); 
            return n;
            
        }

        public string GetWord(string text)
        {
            string giris;

            while (true)
            {
                Console.Write(text);
                giris = Console.ReadLine();
                bool kontrol = true;

                foreach (char chr in giris)
                {
                    if (Char.IsNumber(chr))
                    {
                        Console.WriteLine("Hatali giris yapildi. Tekrar deneyin. ");
                        kontrol = false;
                        break;
                    }
                }
                if (kontrol == true)
                {
                    return giris;
                }
            }
        }



    }
}
