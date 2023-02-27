using System.Globalization;
using CadastroPessoas.Classes;

Console.WriteLine(@$"
============================================================================
|                                                                          |
|                       Bem vindo ao sistema de                            |
|             cadastro de Pessoas Físicas e Pessoas Jurídicas              |
|                                                                          |
============================================================================
");

Utils.BarraCarregamento("Iniciando", 500, 10);
Console.ResetColor();

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    Console.WriteLine(@$"
============================================================================
|                                                                          |
|                     Escolha uma das opções abaixo                        |
|__________________________________________________________________________|
|                          1- Pessoa Fisica                                |
|                          2- Pessoa Juridica                              |
|                                                                          |
|                          0- Sair                                         |
============================================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            string? opcaoPf;

            do
            {
                    Console.WriteLine(@$"
============================================================================
|                                                                          |
|                     Escolha uma das opções abaixo                        |
|__________________________________________________________________________|
|                                                                          |
|                      1- Cadastrar Pessoa Fisica                          |
|                      2- Listar Pessoa Física                             |
|                                                                          |
|                       0- Voltar                                          |
============================================================================
");
            opcaoPf = Console.ReadLine();
                    
            PessoaFisica metodosPf = new PessoaFisica();

            switch (opcaoPf)
            {
                case "1":

                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco endPf = new Endereco();


                    //novaPf.Nome = "Rafael";
                    Console.WriteLine($"Digite o nome: ");
                    novaPf.Nome = Console.ReadLine();

                    //novaPf.Cpf = "48189379755";
                    Console.WriteLine($"Digite o CPF: ");
                    novaPf.Cpf = Console.ReadLine();


                    //novaPf.DataNascimento = new DateTime(2015, 06, 26);
                    bool dataValida;
                    do
                    {
                        Console.WriteLine($"Data de nascimento (DD/MM/AAAA): ");
                        string dataNasc = Console.ReadLine();
                        
                        dataValida = metodosPf.ValidarDataNascimento(dataNasc);

                        if (dataValida)
                        {
                            DateTime dataConvertida;

                            DateTime.TryParse(dataNasc, out dataConvertida);

                            novaPf.DataNascimento = dataConvertida;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Data inválida! Digite uma data válida no formato DD/MM/AAAA");
                            Console.ResetColor();
                        }

                    } while (dataValida == false);

                    //novaPf.Rendimento = 25004.4f;
                    Console.WriteLine($"Digite o rendimento: ");
                    novaPf.Rendimento = float.Parse(Console.ReadLine());

                    //endPf.Logradouro = "Avenida Goias";
                    Console.WriteLine($"Digite o logradouro: ");
                    endPf.Logradouro = Console.ReadLine();

                    //endPf.Numero = 1020;
                    Console.WriteLine($"Digite o número da residência: ");
                    endPf.Numero = int.Parse(Console.ReadLine());

                    //endPf.Complemento = "Casa";
                    Console.WriteLine($"Digite o complemento: ");
                    endPf.Complemento = Console.ReadLine();
                                
                    //endPf.Comercial = false;
                    Console.WriteLine($"Este endereço é comercial?   S - para sim N - Para não");
                    string endCom = Console.ReadLine().ToUpper();
                    if (endCom == "S")
                    {
                        endPf.Comercial = true;
                    }
                    else
                    {
                        endPf.Comercial = false;
                    }

                    novaPf.Endereco = endPf;

                    listaPf.Add(novaPf);

                    // StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                    // sw.WriteLine(novaPf.Nome);
                    // sw.Close();//encerramos o objeto StreamWriter

                    //usando o recurso com using confome documentação
                    using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                    {
                        sw.WriteLine(novaPf.Nome);
                    }


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Cadastro realizado com sucesso!");
                    Thread.Sleep(3000);
                    Console.ResetColor();


                    break;
                case "2":
                    //verificação da lista
                    // if (listaPf.Count > 0)
                    // {
                    //     foreach (PessoaFisica cadaPessoa in listaPf)
                    //     {
                    //         Console.Clear();

                    //         Console.WriteLine(@$"
                    //             Nome: {cadaPessoa.Nome}
                    //             Cpf: {cadaPessoa.Cpf}
                    //             Data de nascimento: {cadaPessoa.DataNascimento}
                    //             Maior de idade: {(metodosPf.ValidarDataNascimento(cadaPessoa.DataNascimento) ? "Sim" : "Não")}
                    //             Maior de idade (string): {(metodosPf.ValidarDataNascimento("05/12/2020") ? "Sim" : "Não")}
                    //             Rendimento: R$ {cadaPessoa.Rendimento}
                    //             Imposto a pagar: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C", new CultureInfo("pt-br"))}
                    //             Endereço: {cadaPessoa.Endereco.Logradouro}, {cadaPessoa.Endereco.Numero}, {cadaPessoa.Endereco.Complemento}, {cadaPessoa.Endereco.Comercial}
                    //         ");
                    //     }
                    //     Console.WriteLine($"Digite 'ENTER' para continuar...");
                    //     Console.ReadLine();
                    // }
                    // else
                    // {
                    //     Console.ForegroundColor = ConsoleColor.DarkBlue;
                    //     Console.WriteLine($"Lista vazia.");
                    //     Thread.Sleep(3000);
                    //     Console.ResetColor();
                    // }

                    using (StreamReader sr = new StreamReader("rafael.txt"))
                    {
                        string? linha;

                        while((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine($"{linha}");
                            
                        }
                    }
                    Console.WriteLine($"Aperte ENTER para continuar");
                    Console.ReadLine();
                    break;
                case "0":
                    //retorna
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opção invalida, selecione outra opção.");
                    Thread.Sleep(3000);
                    Console.ResetColor();
                    break;
            }
            } while (opcaoPf != "0");







//---------------------------------------------------------------------------------------------------
            Console.WriteLine($"Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            novaPj.Nome = "Escola SENAI";
            novaPj.Cnpj = "10655088000133";
            novaPj.RazaoSocial = "SENAI Informática";
            novaPj.Rendimento = 1000000.99f;

            Endereco endPj = new Endereco();
            endPj.Logradouro = "Rua Niteroi";
            endPj.Numero = 180;
            endPj.Complemento = "Senai Informática";
            endPj.Comercial = true;

            novaPj.Endereco = endPj;

            PessoaJuridica metodosPj = new PessoaJuridica();

            metodosPj.Inserir(novaPj);

            List<PessoaJuridica> listaPj = metodosPj.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaPj)
            {
                Console.WriteLine(@$"
                Nome fantasia: {cadaItem.Nome}
                CNPJ: {cadaItem.Cnpj}
                Razão Social: {cadaItem.RazaoSocial}
                ");
                Console.WriteLine("Aperte ENTER para continuar.");
            }




            // Console.WriteLine(@$"
            // Razão social: {novaPj.RazaoSocial}
            // Cnpj: {novaPj.Cnpj}
            // Validação CNPJ: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Cnpj válido!" : "Cnpj invalido")}
            // Rendimento: {novaPj.Rendimento}
            // Imposto a pagar: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
            // Endereco: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}, {novaPj.Endereco.Comercial}
            // ");
            Console.WriteLine($"Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            break;

        case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Console.ResetColor();
            Thread.Sleep(200);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inválida, escolha uma opção válida");
            Console.ResetColor();
            Thread.Sleep(3000);
  
            break;
    }
} while (opcao != "0");



Utils.BarraCarregamento("Finalizando", 500, 10);
