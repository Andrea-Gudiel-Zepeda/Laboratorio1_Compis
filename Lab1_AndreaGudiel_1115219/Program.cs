using System;
using System.Collections.Generic;

namespace Lab1_AndreaGudiel_1115219
{
    class Program
    {
       static List<Token> Expresion = new List<Token>();

        static void Main(string[] args)
        {
            
            string regexp = Console.ReadLine();
            scanner scanner = new scanner(regexp);
            parser Parser = new parser();
            Token nextToken;
            do
            {
                nextToken = scanner.GetToken();
                Expresion.Add(nextToken);
                /*Console.WriteLine("Token: {0}, Valor {1}",
                    nextToken.Tag,
                    nextToken.Value);*/

            } while (nextToken.Tag != TokenType.EOF);


            Parser.Parse(Expresion);
            Console.ReadLine();
        }
    }
}
