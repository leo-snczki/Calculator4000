using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D;
            double OPERADOR=0;
            int OPÇÃO;


            Console.WriteLine("CALCULADORA\n");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("6 - Equação de 2ºgrau");
            Console.WriteLine("7 - Calculo fatorial");
            Console.WriteLine("8 - área de um triangulo");
            Console.WriteLine("9 - volume de uma pirâmide");
            Console.WriteLine("10 - Área de um retângulo");
            Console.WriteLine("11 - Volume de um paralelepipedo");
            Console.WriteLine("12 - Área de um circulo");
            Console.WriteLine("13 - Volume de uma esfera");

            Console.WriteLine("insira a opção desejada: ");
            
            OPÇÃO = Convert.ToInt32(Console.ReadLine());

            switch (OPÇÃO)
            {
                case 1:
                    Console.WriteLine("Insira um valor para A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = A + B;
                    break;

                case 2:
                    Console.WriteLine("Insira um valor para A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = A - B;
                    break;

                case 3:
                    Console.WriteLine("Insira um valor para A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = A * B;
                    break;

                case 4:
                    Console.WriteLine("Insira um valor para A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    while (B == 0)
                    {
                        Console.WriteLine("escreva um número positivo para B:");
                        B = Convert.ToDouble(Console.ReadLine());
                    }

                    OPERADOR = A / B;
                    Console.Write("Escolheu divisão: " + OPERADOR);
                    break;

                case 5:
                    Console.WriteLine("Insira um valor para A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    while (A < 0)
                    {
                        Console.WriteLine("Não existe raiz de valores negativos, insira outro número:");
                        A = Convert.ToDouble(Console.ReadLine());
                    } 

                    OPERADOR = Math.Sqrt(A);

                    /* Não existe raiz quadrada de número positivo
                     O resultado é devolvido em double*/

                    break;


                case 6:

                    do
                    {
                        Console.WriteLine("Insira o valor de a (deve ser diferente de zero):");
                        A = Convert.ToDouble(Console.ReadLine());
                    } while (A<=0);

                    Console.WriteLine("Insira um valor para B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para C:");
                    C = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = (B * B) - (4*A*C);

                     D = Math.Sqrt(OPERADOR);

                    while (D < 0)
                    {
                        Console.WriteLine("Não existe raiz de valores negativos, insira outros números:");
                        Console.WriteLine("Insira um valor para A:");
                        A = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Insira um valor para B:");
                        B = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Insira um valor para C:");
                        C = Convert.ToDouble(Console.ReadLine());
                    }

                    var x1 = ((-(B)) + D) / (2 * A);
                    var x2 = ((-(B)) - D) / (2 * A);

                    Console.WriteLine("Valor de X': {0}", x1);
                    Console.WriteLine("Valor de X'': {0}", x2);


                    break;

                case 7:
                    Console.WriteLine("Insira um valor para A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = 1;
                    B = 1;

                    do
                    {
                        OPERADOR = OPERADOR * B;
                        B += 1;
                    } while (B <= A);

                    break;

                case 8:
                    Console.WriteLine("Insira um valor para Altura:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para Base:");
                    B = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = (B * A) / 2;

                    break;

                case 9:
                    Console.WriteLine("Insira um valor para Altura:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para Base:");
                    B = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = (A* Math.Pow(B, 2))/ 3;


                    break;

                case 10:
                    Console.WriteLine("Insira um valor para Lado A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para Lado B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = A*B;

                    break;
                
                case 11:

                    Console.WriteLine("Insira um valor para Lado A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para Lado B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um valor para Lado C:");
                    C = Convert.ToDouble(Console.ReadLine());

                    OPERADOR = A * B * C;

                    break;
               
                 case 12:
                    Console.WriteLine("Insira o valor do raio:");
                    A = Convert.ToDouble(Console.ReadLine());
                    B = 2;

                    OPERADOR = Math.PI * (Math.Pow(A,B));

                    break;
               
                case 13:
                    Console.WriteLine("Insira o valor do raio:");
                    A = Convert.ToDouble(Console.ReadLine());
                    
                    OPERADOR=(4 * Math.PI * (Math.Pow(A, 3)) / 3);
                    break;


                default:
                    Console.WriteLine("Não existe essa opção");
                    break;

            }
            if (OPÇÃO <= 13 != (OPÇÃO == 6))
            {
                Console.Write("O resultado é: " + OPERADOR);
            }

            Console.ReadKey();
                
                    
        }
    }
}
