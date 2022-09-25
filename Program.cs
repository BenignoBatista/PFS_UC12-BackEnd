// criar uma pessoa física
// preencher o nome
// imprimir no console

using ATIV_UC12_SA2_ER2.Classes;

PessoaFisica eduardo = new PessoaFisica("20/07/2012");

// eduardo.dataNascimento = "1982/07/20";

System.Console.WriteLine(eduardo.ValidarDataNascimento(eduardo.dataNascimento));
// PessoaFisica jose = new PessoaFisica();
// PessoaJuridica robertoImoveis = new PessoaJuridica();

// eduardo.nome = "Eduardo Costa";

// System.Console.WriteLine("Nome do Cara: " + eduardo.nome);
// System.Console.WriteLine($"Nome do Cara:{eduardo.nome}");