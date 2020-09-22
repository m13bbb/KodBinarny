using System;
using System.Collections.Generic;
namespace KodBinarny
{
    public class Parser
    {
        public string parse(List<Token> listaTokenow)
        {
            string tekst = "";

            foreach(Token token in listaTokenow)
            {
                if(token.Nazwa == TypTokenu.SPACJA)
                {
                    tekst = tekst + ZbioryZnakow.SPACJA;
                }
                else if(token.Nazwa == TypTokenu.LITERA)
                {
                    tekst = tekst + ZbioryZnakow.LITERY[token.Argument];
                }
                else if(token.Nazwa == TypTokenu.CYFRA)
                {
                    tekst = tekst + ZbioryZnakow.CYFRY[token.Argument];
                }
                else if(token.Nazwa == TypTokenu.SYMBOL)
                {
                    tekst = tekst + ZbioryZnakow.SYMBOLE[token.Argument];
                }

                tekst = tekst + " ";
            }

            return tekst.Trim();
        }
    }
}
