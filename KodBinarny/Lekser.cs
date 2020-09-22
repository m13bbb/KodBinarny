using System;
using System.Collections.Generic;
namespace KodBinarny
{
    public class Lekser
    {
        public List<Token> analizuj(string tekst)
        {
            List<Token> listaTokenow = new List<Token>();

            int obecnyIndex = 0;

            while(obecnyIndex < tekst.Length)
            {
                if(tekst[obecnyIndex] == ' ')
                {
                    listaTokenow.Add(new Token(obecnyIndex, TypTokenu.SPACJA, tekst[obecnyIndex]));
                }
                else if(ZbioryZnakow.LITERY.ContainsKey(tekst[obecnyIndex]))
                {
                    listaTokenow.Add(new Token(obecnyIndex, TypTokenu.LITERA, tekst[obecnyIndex]));
                }
                else if(ZbioryZnakow.CYFRY.ContainsKey(tekst[obecnyIndex]))
                {
                    listaTokenow.Add(new Token(obecnyIndex, TypTokenu.CYFRA, tekst[obecnyIndex]));
                }
                else if(ZbioryZnakow.SYMBOLE.ContainsKey(tekst[obecnyIndex]))
                {
                    listaTokenow.Add(new Token(obecnyIndex, TypTokenu.SYMBOL, tekst[obecnyIndex]));
                }
                else
                {
                    throw new Exception("Tekst zawiera niedozolony znak");
                }

                obecnyIndex++;
            }

            return listaTokenow;
        }
    }
}
