using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_AndreaGudiel_1115219
{
    public class scanner
    {
        //private const char EOF = (char)0;

        private string _regexp = "";
        private int _index = 0;
        private int _state = 0;

        public scanner(string regexp)
        {
            _regexp = regexp + (char)TokenType.EOF;
            _index = 0;
            _state = 0;
        }

        public Token GetToken()
        {
            Token result = new Token() { Value = (char)0 };
            bool tokenFound = false;
            while (!tokenFound)
            {
                char peek = _regexp[_index];
                switch (_state)
                {
                    case 0:

                        while (char.IsWhiteSpace(peek))
                        {
                            _index++;
                            peek = _regexp[_index];
                        };

                        switch (peek)
                        {
                            case (char)TokenType.Less:
                            case (char)TokenType.Plus:
                            case (char)TokenType.RParen:
                            case (char)TokenType.LParen:
                            case (char)TokenType.Star:
                            case (char)TokenType.Bar:
                            case (char)TokenType.EOF:
                            case (char)TokenType.Cero:
                            case (char)TokenType.One:
                            case (char)TokenType.Two:
                            case (char)TokenType.Three:
                            case (char)TokenType.Four:
                            case (char)TokenType.Five:
                            case (char)TokenType.Six:
                            case (char)TokenType.Seven:
                            case (char)TokenType.Eight:
                            case (char)TokenType.Nine:
                                tokenFound = true;
                                result.Tag = (TokenType)peek;
                                break;
                            default:
                                throw new Exception("Lex Error");


                        } //Switch - peek
                        break; //CASE STATE0
                    default:
                        break;
                } //SWITCH - state
                _index++;
            } // WHILE - tokenFound
            _state = 0;
            return result;
        } //GetToken
    }
}
