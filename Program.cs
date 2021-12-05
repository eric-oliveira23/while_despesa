using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string desc, resp;
                double gasto, valor_total = 0;
                 
                do
                {
                    Console.WriteLine("Informe a descrição da despesa: ");
                    desc = Console.ReadLine();

                    Console.Write("Informe a o gasto da despesa: R$");
                    gasto = double.Parse(Console.ReadLine());
                    valor_total += gasto;

                    Console.WriteLine("Deseja repetir o processo? \n (S)im \n (N)ão");
                    resp = Console.ReadLine().ToUpper();

                    while (resp != "S" && resp != "SIM")
                    {
                        Console.WriteLine("Opção Inválida.");
                        Console.WriteLine("Deseja repetir o processo? \n (S)im \n (N)ão");
                        resp = Console.ReadLine().ToUpper();

                    }
                }
                while (resp =="S" || resp =="SIM");               
            }

            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não corresponde ao contexto atual.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro, tente novamente mais tarde.");
            }

            Console.ReadKey();
        }
    }
}
