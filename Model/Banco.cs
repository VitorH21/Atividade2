using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Atividade2
{
    public class Banco
    {

        private int BancoID;

        List<Agencia> agencias = new List<Agencia>();

        public void AddAgencia(Agencia a)
        {
            Console.Clear();
            agencias.Add(a);
            Console.WriteLine("Agência " + a.IdAgencia + " criada com sucesso!");
            Console.WriteLine("Numero de agencias: " + agencias.Count);
            
        }

        [Key]
        public int IdBanco
        {
            get {return BancoID; }
            set { BancoID = value; }
        }

        public List<Agencia> Agencias
        {
            get;
        }

        public Agencia buscaAgencia(int num)
        {
            Agencia ag = null;
            foreach (var agencia in agencias)
            {
                if (agencia.IdAgencia == num)
                {
                    ag = agencia;
                    return ag;
                }
            }
            Console.WriteLine("A agência não exite, verifique o ID:");
            return null;
            
            
        }

        public void listaAgenciasId()
        {
            foreach (var agencia in agencias)
            {
                Console.WriteLine("Agencia = " + agencia.IdAgencia);
                
            }
        }

    }
}
