using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("o ex1 será codificado aqui");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("o ex2 está codificado aqui");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("o ex3 está codificado aqui");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("o ex4 está codificado aqui");
        }


        static void Main(string[] args)
        {
            int programa = 1;
            do
            {
                Console.WriteLine("digite qualquer valor menos 0 para prosseguir. Digite 0 para finalizar o programa");
                programa = int.Parse(Console.ReadLine());
                int op;
                Console.WriteLine("========MENU========");
                Console.WriteLine("exerc 1");
                Console.WriteLine("exerc 2");
                Console.WriteLine("exerc 3");
                Console.WriteLine("exerc 4");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                   case 1:
                        //Exercicio1();
                        //int[] vet2;
                        //Console.WriteLine("entre com o tamanho");
                        //int t = int.Parse(Console.ReadLine());
                        //vet2 = new int[t];
                        //Random r = new Random();
                        //int media;
                        //int soma = 0;
                        //for (int i = 0; i < t; i++)

                        //{

                        //    vet2[i] = r.Next(10, 50);

                        //    soma = soma + vet2[i];
                        //}
                        //for (int i = 0; i < t; i++)
                        //{
                        //    Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
                        //}

                        //media = soma / t;
                        //Console.WriteLine(media);

                        break;

                   case 2:
                       
                        //Exercicio2();
                        //int[] vet2;
                        //Console.WriteLine("Entre com o tamanho do vetor:");
                        //int t = int.Parse(Console.ReadLine());
                        //vet2 = new int[t];
                        //Random r = new Random();
                        //int somaPares = 0;
                        //int somaImpares = 0;

                        //for (int i = 0; i < t; i++)
                        //{
                        //    vet2[i] = r.Next(10, 50);
                        //    Console.WriteLine("Posição [{0}] = {1}", i, vet2[i]);

                        //    if (vet2[i] % 2 == 0)
                        //    {
                        //        somaPares += vet2[i];
                        //    }
                        //    else
                        //    {
                        //        somaImpares += vet2[i];
                        //    }
                        //}

                        //Console.WriteLine("Soma dos valores pares: {0}", somaPares);
                        //Console.WriteLine("Soma dos valores ímpares: {0}", somaImpares);
                

                break;

                   case 3:
                        Exercicio3();
                        break;

                   case 4:
                        Exercicio4();
                        break;



                }
            } while (programa != 0);
        }
    }
}
