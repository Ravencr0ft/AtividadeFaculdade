using System;
using System.Numerics;
namespace CAL
{

    class MainClass
    {
        static string CPAL(BigInteger quilometros)
        {
            BigInteger ALEMK = new BigInteger();
            LightYearInKilometers = 9460730472580800;             

            double result = (double)kilometers / (double)ALEMK;

            return string.Format("{0}", result);
        }

        static string CPK(BigInteger AL)
        {
            BigInteger ALEMK = new BigInteger();
            ALEMK = 9460730472580800;             

            return string.Format("{0}", ALEMK * AL);
        }

        static void GetUserValue(int SelectedOption)
        {
            string Result;

            Console.Write("Insira o valor que deseja converter: ");
            switch (SelectedOption)
            {
                case 1:
                    BigInteger UserValueOption1 = new BigInteger();
                    UserValueOption1 = BigInteger.Parse(Console.ReadLine());
                    Result = CPK(UserValueOption1);

                    Console.WriteLine("O resultado é: {0} km", Result);
                    break;
                case 2:
                    BigInteger UserValueOption2 = new BigInteger();
                    UserValueOption2 = BigInteger.Parse(Console.ReadLine());
                    Result = CPAL(UserValueOption2);

                    Console.WriteLine("O resultado é: {0} ly", Result);
                    break;
                default:
                    break;
            }

            Console.Read();
        }

        static void Main(string[] args)
        {
            string Version = "1.0";
            string Option;

            Console.WriteLine("=================================");
            Console.WriteLine("Conversor de Anos-Luz", Version);
            Console.WriteLine("=================================\n");

            Console.WriteLine("Escolha uma das opções abaixo (qualquer outra tecla para sair):");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("(1) Anos-Luz para Quilômetros");
            Console.WriteLine("(2) Quilômetros para Anos-Luz\n");

            Console.Write("Sua escolha: ");
            Option = Console.ReadLine();

            switch (Option)
            {
                case "1":
                    GetUserValue(1);
                    break;
                case "2":
                    GetUserValue(2);
                    break;
                default:
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}