using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Atividade2
{
    public class ContaCorrente
    {
        public const decimal Taxa = 0.10M;
        public string titular = string.Empty;
        private int ContaCorrenteID;

        public ContaCorrente(){}

        public ContaCorrente(string t)
        {
            this.titular = t;
        }

        [Key]
        public int Id
        {
            get {return ContaCorrenteID; }
            set { ContaCorrenteID = value; }
        }

        public void DepositarDinheiro(decimal valor)
        {
            decimal desconto = valor * Taxa;
            Saldo += valor;
        }

        public void SacarDinheiro(decimal valor)
        {
            decimal desconto = valor * Taxa;
            
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
        }

        public decimal Saldo { get; set; }

        public string Titular {
            get {return titular; }
            set { titular = value; }
        }

       

    }
}
