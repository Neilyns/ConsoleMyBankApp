using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Neilyane Silva", "000.000.000-00", "Analista de Planejamento");

           
            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            conta.titular = cliente;
            conta.agencia = 01;
            conta.conta = 0001;

            Console.WriteLine("Conta Corrente Criada ");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de R${0}, obrigada por criar sua conta!", conta.getSaldo());

            double valorDeposito = 200;
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            double valorSaque = 200;
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            Cliente clienteIlene = new Cliente("Ilene de Souza Silva", "000.000.000-00", "Administradora");

            ContaCorrente contaIlene = new ContaCorrente(clienteIlene, 01, 0002);

            double valorPix = 100;
            conta.Pix(valorPix, contaIlene);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}", contaIlene.getSaldo());

            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);

            Console.WriteLine("Conta Poupança Criada");
            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agência: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());
        }
    }
}
