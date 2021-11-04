using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();
            string[] words = tekst.Split(' ');      //do tablicy words zapisujemy słowa jako elementy
            
            foreach(string word in words)
            {
                char[] slowo = word.ToCharArray();      //poszczegolne słowa zapisujemy jako tablice charów zamiast string
                Array.Reverse(slowo);                   //odwracamy kolejność elementów tablicy (odwracamy słowo)
                Console.Write(slowo);
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}
