using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Atividade2
{
    public class Solicitacao
    {
        private int idSoliciacao;
        public void realizarSolicitacao(Banco banco)
        {
            Console.WriteLine("Digite o Id da agência: ");
            int numAgencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Tipos da conta: ");
            Console.WriteLine("1 - Corrente");
            Console.WriteLine("2 - Poupança");
            Console.WriteLine("Digite o tipos da conta: ");
            int tipo_conta = int.Parse(Console.ReadLine());
            Console.Clear();

            if (tipo_conta == 1)
            {
                Agencia agencia = banco.buscaAgencia(numAgencia);
                if (agencia == null)
                {
                    return;
                }

                Console.WriteLine("Digite o número da conta: ");
                int num_conta = int.Parse(Console.ReadLine());

                ContaCorrente cc = agencia.getContaCorrente(num_conta);
                if (cc == null)
                {
                    return;
                }
                Console.WriteLine("+++++++++++++++++++++++");
                Console.WriteLine("O que deseja realizar: ");
                Console.WriteLine("1 - Consultar Saldo    ");
                Console.WriteLine("2 - Sacar              ");
                Console.WriteLine("3 - Depositar          ");
                Console.WriteLine("+++++++++++++++++++++++");
                int operacao = int.Parse(Console.ReadLine());
                Console.Clear();

                if (operacao == 1)
                {
                    Console.WriteLine("++++++++++++++++++++");
                    Console.WriteLine("Conta = " + cc.Id);
                    Console.WriteLine("Titular = " + cc.Titular);
                    Console.WriteLine("Seu saldo é = R$ " + cc.Saldo);
                    Console.WriteLine("++++++++++++++++++++");
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("SAQUE");
                    Console.WriteLine("Digite o valor para saque: ");
                    cc.SacarDinheiro(decimal.Parse(Console.ReadLine()));
                    Console.Clear();

                }
                else if (operacao == 3)
                {
                    Console.WriteLine("DEPÓSITO");
                    Console.WriteLine("Digite o valor para depositar: ");
                    cc.DepositarDinheiro(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                }
            }
            else if (tipo_conta == 2)
            {
                Console.WriteLine("Digite o numero da conta: ");
                int num_conta = int.Parse(Console.ReadLine());
                Console.Clear();
                Agencia agencia = banco.buscaAgencia(numAgencia);
                if (agencia == null)
                {
                    return;
                }
                ContaPoupanca cp = agencia.getContaPoupanca(num_conta);
                if (cp == null)
                {
                    return;
                }

                Console.WriteLine("+++++++++++++++++++++++");
                Console.WriteLine("O que deseja realizar: ");
                Console.WriteLine("1 - Consultar Saldo    ");
                Console.WriteLine("2 - Sacar              ");
                Console.WriteLine("3 - Depositar          ");
                Console.WriteLine("+++++++++++++++++++++++");
                int operacao = int.Parse(Console.ReadLine());
                Console.Clear();

                if (operacao == 1)
                {
                    Console.WriteLine("++++++++++++++++++++");
                    Console.WriteLine("Conta = " + cp.Id);
                    Console.WriteLine("Titular = " + cp.Titular);
                    Console.WriteLine("Seu saldo é = R$ " + cp.Saldo);
                    Console.WriteLine("++++++++++++++++++++");
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("SAQUE");
                    Console.WriteLine("Digite o valor para saque: ");
                    cp.SacarDinheiro(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("DEPÓSITO");
                    Console.WriteLine("Digite o valor para depositar: ");
                    cp.DepositarDinheiro(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                }
            }
        }

        [Key]
        public int IdSolicitacao {
            get { return idSoliciacao; }
            set { idSoliciacao = value; }
        }
    }
}
