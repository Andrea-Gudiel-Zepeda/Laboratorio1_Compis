using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_AndreaGudiel_1115219
{
    public class parser
    {
        
        static List<char> PILA = new List<char>();
        static List<Token> Entrada = new List<Token>();

        private void S(Token _token)
        {
            switch (_token.Tag)
            {
                case TokenType.Less:
                case TokenType.LParen:
                case TokenType.Cero:
                case TokenType.One:
                case TokenType.Two:
                case TokenType.Three:
                case TokenType.Four:
                case TokenType.Five:
                case TokenType.Six:
                case TokenType.Seven:
                case TokenType.Eight:
                case TokenType.Nine:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('E');
                    PILA.Add('T');
                    break;
                default:
                    throw new Exception("Sintaxis Error");

            }
        }

        private void E(Token _token)
        {
            switch (_token.Tag)
            {
                case TokenType.Plus:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('E');
                    PILA.Add('T');
                    PILA.Add('+');
                    break;
                case TokenType.Less:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('E');
                    PILA.Add('T');
                    PILA.Add('-');
                    break;
                case TokenType.RParen:
                case TokenType.EOF:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    break;
                default:
                    throw new Exception("Sintaxis Error");

            }
        }

        private void T(Token _token)
        {
            switch (_token.Tag)
            {
                case TokenType.Less:
                case TokenType.LParen:
                case TokenType.Cero:
                case TokenType.One:
                case TokenType.Two:
                case TokenType.Three:
                case TokenType.Four:
                case TokenType.Five:
                case TokenType.Six:
                case TokenType.Seven:
                case TokenType.Eight:
                case TokenType.Nine:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('A');
                    PILA.Add('F');
                    break;

                default:
                    throw new Exception("Sintaxis Error");

            }
        }

        private void A(Token _token)
        {
            switch (_token.Tag)
            {
                case TokenType.Less:
                case TokenType.Plus:
                case TokenType.RParen:
                case TokenType.EOF:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    break;

                case TokenType.Star:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('A');
                    PILA.Add('F');
                    PILA.Add('*');
                    break;

                case TokenType.Bar:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('A');
                    PILA.Add('F');
                    PILA.Add('/');
                    break;

                default:
                    throw new Exception("Sintaxis Error");

            }
        }

        private void F(Token _token)
        {
            switch (_token.Tag)
            {
                case TokenType.Less:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('F');
                    PILA.Add('-');
                    break;

                case TokenType.LParen:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add(')');
                    PILA.Add('S');
                    PILA.Add('(');
                    break;

                case TokenType.Cero:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('0');
                    break;
                case TokenType.One:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('1');
                    break;
                case TokenType.Two:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('2');
                    break;
                case TokenType.Three:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('3');
                    break;
                case TokenType.Four:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('4');
                    break;
                case TokenType.Five:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('5');
                    break;
                case TokenType.Six:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('6');
                    break;
                case TokenType.Seven:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('7');
                    break;
                case TokenType.Eight:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('8');
                    break;
                case TokenType.Nine:
                    PILA.Remove(PILA[PILA.Count - 1]);
                    PILA.Add('9');
                    break;

                default:
                    throw new Exception("Sintaxis Error");

            }

        }

        public bool Parse(List<Token> regex)
        {
            Entrada = regex;
            bool correcto = false;
            PILA.Add((char)TokenType.EOF);
            PILA.Add('S');
            
            do
            {
                int TamañoPila = PILA.Count;
                switch (PILA[TamañoPila-1])
                {
                    case 'S':
                        S(Entrada[0]);
                        break;
                    case 'E':
                        E(Entrada[0]);
                        break;
                    case 'T':
                        T(Entrada[0]);
                        break;
                    case 'A':
                        A(Entrada[0]);
                        break;
                    case 'F':
                        F(Entrada[0]);
                        break;

                    //Terminales - Tokens
                    case '0':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '1':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '2':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '3':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '4':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '5':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '6':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '7':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '8':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '9':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '+':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '-':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '*':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '/':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case '(':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    case ')':
                        PILA.Remove(PILA[PILA.Count - 1]);
                        Entrada.Remove(Entrada[0]);
                        break;

                    default:
                       if( PILA[TamañoPila - 1] == (char)TokenType.EOF)
                       {
                            correcto = true;
                       }
                       break;
                }

            } while (!correcto);


            return correcto;
        }
    }
}
