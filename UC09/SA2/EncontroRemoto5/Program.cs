using System.Globalization;
using System.Text.RegularExpressions;
using EncontroRemoto2.Classes;

//instanciar um objeto da classe PessoaFisica
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

Console.Clear();

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

//--------------------------------------------------------------------

PessoaJuridica novaPj = new PessoaJuridica();

novaPj.Cnpj = "10655088000133";
novaPj.RazaoSocial = "SENAI Informática";
novaPj.Rendimento = 1000000.99f;

Endereco endPj = new Endereco();
endPf.Logradouro = "Rua Niteroi";
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


//validar data DD/MM/AAAA
//string data = "01/11/20222";
//bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
//Console.WriteLine(valido);

//Ex substring
//string texto = "Ferrari";
//string substring = texto.Substring(0, 4);
//Console.WriteLine(substring);