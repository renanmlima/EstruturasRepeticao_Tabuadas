using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasRepetição_Tabuadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* |====================================================| */
            /* |* AUTOR: RENAN LIMA | RA: 6321300 ******************| */
            /* |* DATA DE CRIAÇÃO: 09.JUN.2022 *********************| */
            /* |* ATIVIDADE PROPOSTA PELO PROFESSOR DJALMA *********| */
            /* |* MATÉRIA: LÓGICA DE PROGRAMAÇÃO *******************| */
            /* |* SEMESTRE: 1 | INSTITUIÇÃO: UNIFAAT ATIBAIA *******| */
            /* |* CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS *****| */
            /* |====================================================| */

            // variáveis responsaveis pelos valores permitidos na tabuada, n1 e n2 definiram até onde será mostrada
            int n1, n2, tab, sw; 
            
            Console.Write("Por favor, insira qual tabuada você quer visualizar: ");
            tab = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a partir de que número você quer visualizar (0-100): ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira até que número você quer visualizar ("+n1+"-100): ");
            n2 = Convert.ToInt32(Console.ReadLine());


            // condição que checa se o valor de n1 e n2 correspondem com o definido de no minimo 0 e máximo 100
            // além disso, o n2 não pode ser menor que n1
            if (((n1 < 0) || (n1 > 100)) || ((n2 < n1) || (n2 > 100))) {

                Console.WriteLine("Favor, insira um valor válido!!!");//mensagem de erro

            }
            else
            {
                // seleção de que ordem a tabuada será exibida
                Console.Write("\n Selecione de que forma quer visualizar \n\n 1 - Crescente \n 2 - Descrecente \n -> "); 
                sw = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                switch (sw)
                {
                    // caso seja digitado 1, a tabuada aparecerá de forma crescente
                    case 1:

                        int i = n1;
                        Console.WriteLine("...........................\n");
                        Console.WriteLine("Estrutura utilizando For\n");
                        for(; i <= n2; i++)
                        {
                            Console.WriteLine(i +" x " +tab +" = " +i * tab);
                        }

                        i = n1;
                        Console.WriteLine("...........................\n");
                        Console.WriteLine("Estrutura utilizando While\n");
                        while (i <= n2)
                        {
                            Console.WriteLine(i +" x " +tab +" = " +i * tab);
                            i++;
                        }


                        i = n1;
                        Console.WriteLine("...........................\n");
                        Console.WriteLine("Estrutura utilizando Do While\n");
                        do
                        {
                            Console.WriteLine(i +" x " +tab +" = " +i * tab);
                            i++;
                        }

                        while (i <= n2);
                        
                        break;

                    // caso seja digitado 2, a tabuada aparecerá de forma descrecente
                    case 2:

                        int j = n2;
                        Console.WriteLine("...........................\n");
                        Console.WriteLine("Estrutura utilizando For\n");
                        for (;j >= n1; j--)
                        {
                            Console.WriteLine(j +" x " +tab +" = " + j * tab);
                        }

                        j = n2;
                        Console.WriteLine("...........................\n");
                        Console.WriteLine("Estrutura utilizando While\n");
                        while (j >= n1)
                        {
                            Console.WriteLine(j +" x " +tab +" = " + j * tab);
                            j--;
                        }


                        j = n2;
                        Console.WriteLine("...........................\n");
                        Console.WriteLine("Estrutura utilizando Do While\n");
                        do
                        {
                            Console.WriteLine(j +" x " +tab +" = " + j * tab);
                            j--;
                        }

                        while (j >= n1);

                        break;
                }

            }
            
            //// CÓDIGO EXTRA
            //// Mostrar as tabuadas de 1 a 10 em sequência.

            //int mult = 0, produto, op = 0;

            //while (mult <= 10)
            //{
            //    Console.WriteLine("--------------------");
            //    Console.WriteLine("TABUADA DO " + mult);
            //    Console.WriteLine("--------------------");

            //    while (op <= 10)
            //    {

            //        produto = mult * op;
            //        Console.WriteLine(mult + " x " + op + " = " + produto);
            //        op = op + 1;

            //    }

            //    mult = mult + 1;
            //    op = op - 10;
            //}
            
            Console.ReadKey();

        }
    }
}
