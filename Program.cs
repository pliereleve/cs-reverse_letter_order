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
            string[] words = tekst.Split(' ');      //do tablicy words zapisujemy slowa jako elementy
            
            foreach(string word in words)
            {
                char[] slowo = word.ToCharArray();      //poszczegolne slowa zapisujemy jako tablice charow zamiast string
                Array.Reverse(slowo);                   //odwracamy kolejnosc elementow tablicy (odwracamy slowo)
                Console.Write(slowo);
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}
