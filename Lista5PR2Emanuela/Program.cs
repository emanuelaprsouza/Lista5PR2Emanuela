using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2Emanuela
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int programa;

            for (int i = 0; i != 8 && i <= 7; i++)
            {
                Console.WriteLine(" \n qual o programa que você deseja executar? \n digite 0 para finalizar \n ");
                programa = int.Parse(Console.ReadLine());

                if (programa == 0)
                {
                    break;
                }

                switch(programa)
                {
                    case  1 :
                        int n;
                    Console.WriteLine(" \n digite o numero desejado: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int j = 0; j <= n; j++)
                    {
                        Console.WriteLine(j);
                    }
                    Console.WriteLine();
                    break;

                    case  2 :
                        int num;
                    Console.WriteLine(" digite o numero desejado: ");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int j = 0; j <= num; j++)
                    {
                        if(j % 2 == 0)
                                Console.WriteLine(j);
                    }
                    Console.WriteLine();
                    break;

                    case  3 :
                        int numm;
                    Console.WriteLine(" digite o numero desejado: ");
                    numm = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int j = 1000; j >= numm; j--)
                    {
                       if(j % 2 == 0)
                                Console.WriteLine(j);
                    }
                    Console.WriteLine();
                    break;

                    case  4 :
                        {
                             int num1;
                             num1 = 0;
                        for (int j = 0; num1 < 200; j++)
                        {
                            Console.WriteLine(" digite um numero: ");
                            int num2 = int.Parse(Console.ReadLine());
                            if(num2 > 0)
                                    num1 = num1 + num2;
                            Console.WriteLine(num2 + " soma total: " + num1);
                        }
                        }
                    break;

                    case  5 :
                        {
                        double nummm;
                        Console.WriteLine(" digite o numero desejado: ");
                        nummm = double.Parse(Console.ReadLine());
                        for (int j = 1; j <= nummm; j++)
                        {
                            if (nummm % j == 0)
                            {
                                Console.WriteLine(j);
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                    case  6 :
                        int numero, maior, menor;
                    Console.WriteLine(" digite um numero: ");
                    maior = int.Parse(Console.ReadLine());
                    menor = maior;
                    for (int j = 0; j < 9; j++)
                    {
                        Console.WriteLine(" digite um numero: ");
                        numero = int.Parse(Console.ReadLine());
                        if(numero > maior)
                                maior = numero;
                        if (numero < menor)
                            menor = numero;
                    }
                    Console.WriteLine(" O menor número é: " + menor + " eo maior é: " + maior);
                    break;

                    case  7 :
                        {
                        int numeroo, somai, somap;
                        somap = 0;
                        somai = 0;
                        for (int j = 1; j != 0; j++)
                        {
                            Console.WriteLine(" digite um numero: ");
                            numeroo = int.Parse(Console.ReadLine());
                            if (numeroo == 0)
                                break;
                            if (numeroo % 2 == 0)
                                somap = somap + numeroo;
                            else
                                somai = somai + numeroo;
                        }
                        Console.WriteLine(" soma dos numeros pares: " + somap);
                        Console.WriteLine(" soma dos numeros impares: " + somai);
                        break;
                        }

                       
                             default:
                                 break;
                }
            }

            Console.ReadKey();
        }
    }
}
