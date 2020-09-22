using System;
namespace KodBinarny
{
    public class Token
    {
        public int Index { get; set; }
        public string Nazwa { get; set; }
        public char Argument { get; set; }

        public Token(int index, string nazwa, char argument)
        {
            Index = index;
            Nazwa = nazwa;
            Argument = argument;
        }
    }
}
