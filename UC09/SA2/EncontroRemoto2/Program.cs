using EncontroRemoto2.Classes;

//instanciar um objeto da classe PessoaFisica
PessoaFisica novaPf = new PessoaFisica();

novaPf.Nome = "Rafael";
novaPf.Rendimento = 50000.58f; 

Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.Rendimento);


PessoaJuridica novaPj = new PessoaJuridica();

novaPj.RazaoSocial = "SENAI Informática";

Console.WriteLine($"Razão Social: {novaPj.RazaoSocial}");