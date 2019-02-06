using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Atividade2
{
    public class Agencia
    {
        private int AgenciaID;

        List<ContaCorrente> contasCorrente = new List<ContaCorrente>();
        List<ContaPoupanca> contasPoupanca = new List<ContaPoupanca>();
        List<Solicitacao> solicitacoes = new List<Solicitacao>();

        public void AddContaCorrente(ContaCorrente cc)
        {
            contasCorrente.Add(cc);
            Console.WriteLine("Conta " + cc.Id + " de titular " + cc.Titular + " criada com exito!");
        }

        public void AddContaPoupanca(ContaPoupanca cp)
        {
            contasPoupanca.Add(cp);
            Console.WriteLine("Conta " + cp.Id + " de titular " + cp.Titular + " criada com exito!");
        }

        public ContaCorrente getContaCorrente(int num)
        {
            ContaCorrente cCorrentes = null;
            foreach (var conta in contasCorrente)
            {
                if (conta.Id == num)
                {
                    cCorrentes = conta;
                    return cCorrentes;
                }
            }

            Console.WriteLine("Erro! Conta não cadastrada! Verifique seu número!");
            return null;
        }
        public ContaPoupanca getContaPoupanca(int num)
        {
            ContaPoupanca cPoupanca = null;
            foreach (var conta in contasPoupanca)
            {
                if (conta.Id == num)
                {
                    cPoupanca = conta;
                    return cPoupanca;
                }
            }
            Console.WriteLine("Erro! Conta não cadastrada! Verifique seu número!");
            return null;
        }

        [Key]
        public int IdAgencia
        {
            get { return AgenciaID; }
            set { AgenciaID = value; }
        }

        public List<ContaCorrente> ContaCorrentes
        {
            get; set;
        }
        public List<ContaPoupanca> ContaPoupancas
        {
            get; set;
        }
        public List<Solicitacao> Solicitacoes
        {
            get; set;
        }

    }
}
