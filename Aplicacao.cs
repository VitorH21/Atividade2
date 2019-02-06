using System;


namespace Atividade2
{
    class Aplicacao
    {
        public const decimal Juros = 0.6M;

        

        static void Main(string[] args)
        {
            int sum = 1;
            int contaCorrenteID = 1;
            int contaPoupancaID = 1;

            using (var dbcontext = new StoreContext())
            {
                
                dbcontext.Set<Agencia>().RemoveRange(dbcontext.Agencias);
                dbcontext.Set<Banco>().RemoveRange(dbcontext.Bancos);
                dbcontext.Set<Cliente>().RemoveRange(dbcontext.Clientes);
                dbcontext.Set<ContaCorrente>().RemoveRange(dbcontext.ContasCorrentes);
                dbcontext.Set<ContaPoupanca>().RemoveRange(dbcontext.ContasPoupanca);
                dbcontext.Set<Solicitacao>().RemoveRange(dbcontext.Solicitacoes);
                dbcontext.SaveChanges();

                Banco bb = new Banco();
                dbcontext.Bancos.Add(bb);
                dbcontext.SaveChanges();
                Console.Clear();

                while (true)
                {
                    bb.listaAgenciasId();
                    MenuAgencia();
                    int op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Agencia agencia = new Agencia();
                        agencia.IdAgencia = sum;
                        bb.AddAgencia(agencia);
                        sum++;

                        dbcontext.Agencias.Add(agencia);
                        dbcontext.SaveChanges();

                    }
                    else if (op == 2)
                    {
                        Console.Clear();
                        Cliente cliente = new Cliente();
                        Console.WriteLine("Digite o nome do cliente: ");
                        string nome_cliente = Console.ReadLine();
                        Console.Clear();
                        cliente.Nome = nome_cliente;
                        dbcontext.Clientes.Add(cliente);
                        dbcontext.SaveChanges();
                        

                        Console.WriteLine("Quaç tipo de conta desejas criar?: \n");
                        Console.WriteLine("1 - Corrente ");
                        Console.WriteLine("2 - Poupança ");

                        int tipo_de_conta = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (tipo_de_conta == 1)
                        {
                            ContaCorrente ContCorrente = new ContaCorrente(cliente.Nome);
                            Console.WriteLine("Digite o Id da agência: ");
                            int numAgencia = int.Parse(Console.ReadLine());

                            Agencia agencia = bb.buscaAgencia(numAgencia);
                            if (agencia != null)
                            {
                                ContCorrente.Id = contaCorrenteID;
                                agencia.AddContaCorrente(ContCorrente);
                                contaCorrenteID++;
                                dbcontext.ContasCorrentes.Add(ContCorrente);
                                dbcontext.SaveChanges();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Por favor tente novamente!");
                                Console.Clear();
                            }
                        }
                        else if (tipo_de_conta == 2)
                        {
                            ContaPoupanca ContPoupanca = new ContaPoupanca(Juros, DateTime.Now, cliente.Nome);
                            Console.WriteLine("Digite o ID da agência: ");
                            int numAgencia = int.Parse(Console.ReadLine());

                            Agencia agencia = bb.buscaAgencia(numAgencia);
                            if (agencia != null)
                            {
                                ContPoupanca.Id = contaPoupancaID;
                                agencia.AddContaPoupanca(ContPoupanca);
                                contaPoupancaID++;
                                dbcontext.ContasPoupanca.Add(ContPoupanca);
                                dbcontext.SaveChanges();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Por favor tente novamente!");
                                Console.Clear();
                            }

                        }
                    }
                    else if (op == 3)
                    {
                        Solicitacao solicitacao = new Solicitacao();
                        solicitacao.realizarSolicitacao(bb);
                        dbcontext.Solicitacoes.Add(solicitacao);
                        dbcontext.SaveChanges();
                    

                    }
                    else if (op == 4)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                        Console.Clear();
                    }


                }
            }
        }

        public static void MenuAgencia()
            {
                Console.WriteLine("|++++++++++++++++++++++++|");
                Console.WriteLine("| 1 - Cadastrar Agência   ");
                Console.WriteLine("| 2 - Criar Conta         ");
                Console.WriteLine("| 3 - Abrir uma Sessão    ");
                Console.WriteLine("| 4 - Encerrar programa   ");
                Console.WriteLine("|++++++++++++++++++++++++|");
                Console.WriteLine("Digite um a operação a ser realizada: ");
            }


        
    }
}