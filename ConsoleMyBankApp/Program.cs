using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Neilyane Silva", "000.000.000-00", "Analista de Planejamento");

           
            ContaCorrente conta = new ContaCorrente();

            conta.titular = cliente;
            conta.agencia = 01;
            conta.conta = 0001;

            Console.Write("Conta Corrente Criada ");
            Console.WriteLine("Titular: {0}", conta.titular.nome);
            Console.WriteLine("Agência: {0}", conta.agencia);
            Console.WriteLine("Conta: {0}", conta.conta);
        }
    }
}
