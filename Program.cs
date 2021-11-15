using System;

namespace Weekly_11_15
{
    class Program
    {
        static string ReverseCase(string s)
        {
            char[] a = s.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsLower(a[i]))
                    a[i] = Char.ToUpper(a[i]);
                else if (Char.IsUpper(a[i]))
                    a[i] = Char.ToLower(a[i]);
            }
            return new string (a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseCase("Happy Birthday"));
            Console.WriteLine(ReverseCase("MANY THANKS"));
            Console.WriteLine(ReverseCase("sPoNtAnEoUs"));
        }
    }
}
