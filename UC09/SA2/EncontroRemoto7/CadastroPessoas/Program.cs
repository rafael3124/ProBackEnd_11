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
            PessoaFisica novaPf = new PessoaFisica();
            novaPf.Nome = "Rafael";
            novaPf.Cpf = "48189379755";
            novaPf.DataNascimento = new DateTime(2015, 06, 26);
            novaPf.Rendimento = 25004.4f;

            Endereco endPf = new Endereco();
            endPf.Logradouro = "Avenida Goias";
            endPf.Numero = 1020;
            endPf.Complemento = "Casa";
            endPf.Comercial = false;

            novaPf.Endereco = endPf;

            PessoaFisica metodosPf = new PessoaFisica();


            Console.WriteLine(@$"
            __________________________
            |                         |
            |      Pessoa Fisica      |
            |_________________________|

            Nome: {novaPf.Nome}
            Cpf: {novaPf.Cpf}
            Data de nascimento: {novaPf.DataNascimento}
            Maior de idade: {(metodosPf.ValidarDataNascimento(novaPf.DataNascimento) ? "Sim" : "Não")}
            Maior de idade (string): {(metodosPf.ValidarDataNascimento("05/12/2020") ? "Sim" : "Não")}
            Rendimento: R$ {novaPf.Rendimento}
            Imposto a pagar: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C", new CultureInfo("pt-br"))}
            Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}, {novaPf.Endereco.Comercial}
            ");

            Console.WriteLine($"Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();

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

            Console.WriteLine(@$"
            __________________________
            |                         |
            |     Pessoa Jurídica     |
            |_________________________|

            Razão social: {novaPj.RazaoSocial}
            Cnpj: {novaPj.Cnpj}
            Validação CNPJ: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Cnpj válido!" : "Cnpj invalido")}
            Rendimento: {novaPj.Rendimento}
            Imposto a pagar: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
            Endereco: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}, {novaPj.Endereco.Comercial}
            ");
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

Utils.BarraCarregamento("Finalizando", 2000, 10);
