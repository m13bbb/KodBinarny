using System;
using System.Collections.Generic;

namespace KodBinarny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst");
            string tekst = Console.ReadLine();

            Lekser lekser = new Lekser();

            List<Token> listaTokenow = lekser.analizuj(tekst);

            Console.WriteLine("Lista tokenów po analizie lekserem");

            foreach (var token in listaTokenow)
            {
                Console.WriteLine("<{0},{1},{2}>", token.Index, token.Nazwa, token.Argument);
            }

            Console.WriteLine("Lista tokenów po parsowaniu na kod binarny");

            Parser parser = new Parser();

            Console.WriteLine(parser.parse(listaTokenow));
        }
    }
}
