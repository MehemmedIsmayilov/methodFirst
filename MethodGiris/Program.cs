using System;

namespace MethodGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            

            HasilMethod(5, 6);

            KvadratMethod(5);

            int[] arr = { 100, 200, 300 };
            ArrayToplamiMethod(arr);

            SozBirlesdirmeMethodu("Null", "Null");

            TersCevirmeMEthodu("Salam");

            YediiyeBolme(13);

            OverloadMethod(2,2,2);
            OverloadMethod(2);

            string methodCumle = "Salam dostlar necesiz ?";
            StringSentence(methodCumle);

            

        }

        public static void HasilMethod(int a,int b)
        {
            Console.WriteLine(a*b);
        }

        public static void KvadratMethod(int a)
        {
            Console.WriteLine(a*a);
        }
        public static void ArrayToplamiMethod(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
               sum= array[i] +array[i];
                
            }
            Console.WriteLine(sum);
            
        }
        public static void SozBirlesdirmeMethodu(string name,string surname)
        {
            Console.WriteLine($"Xos Gelmisen {name} {surname}");
        }
        public static void TersCevirmeMEthodu(string cumle)
        {
            for (int i = cumle.Length-1; i >= 0; i--)
            {
                Console.Write(cumle[i]);
            }
            Console.WriteLine();
            
        }
        public static void YediiyeBolme(int num)
        {
            if (num % 7 == 0)
            {
                Console.WriteLine("Eded 7-ye bolunur");
            }
            else
            {
                num ++;
                Console.WriteLine(num);
            }
        }
        public static void OverloadMethod(int a,int b,int c)
        {
            Console.WriteLine(a+b+c);
        }
        public static void OverloadMethod(int a)
        {
            Console.WriteLine(a*4);
        }
        public static void StringSentence(string a)
        {
            int sum = 0;
            
                for (int i = 0; i < a.Length; i++)
                {
                if (a == " ")
                {
                    sum += i;
                }
                }

            Console.WriteLine(sum);
            
        }
    }
}
