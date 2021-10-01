using System;
using System.Collections.Generic;

namespace Lab1_AndreaGudiel_1115219
{
    class Program
    {
       static List<Token> Expresion = new List<Token>();

        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("BIENVENIDO AL COMPILADOR");
            Console.WriteLine("¿Desea evaluar una expresion?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No, salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese la expresion a evaluar");
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


                            bool aceptado = Parser.Parse(Expresion);

                            if (aceptado)
                            {
                                Operar operando = new Operar();
                                var resultado = operando.Operando(regexp);

                                Console.WriteLine("El resultado de la expresion " + regexp + " es: " + resultado);
                                //Console.ReadLine();
                            }

                            Expresion.Clear();

                        }
                        break;

                    case 0:
                        break;

                    default:
                        throw new Exception(" Error");
                }
                
                Console.WriteLine("Desea Ingresar otra opcion? 1/0");
                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion == 1);
            
        }
    }
}
