using System;
using System.Text.RegularExpressions;
// criar uma pessoa física
// preencher o nome
// imprimir no console

using ATIV_UC12_SA2_ER2.Classes;

// PessoaJuridica senai = new PessoaJuridica();

// eduardo.dataNascimento = "1982/07/20";

// System.Console.WriteLine(eduardo.ValidarDataNascimento(eduardo.dataNascimento));
// PessoaFisica jose = new PessoaFisica();
// PessoaJuridica robertoImoveis = new PessoaJuridica();

// eduardo.nome = "Eduardo Costa";

// System.Console.WriteLine("Nome do Cara: " + eduardo.nome);
// System.Console.WriteLine($"Nome do Cara:{eduardo.nome}");


//Preenchendo o objeto de endereço
// Endereco novoEndereco = new Endereco();
// novoEndereco.logradouro = "Rua de Casa";
// novoEndereco.numero = 50;
// novoEndereco.comercial = false;


// PessoaFisica eduardo = new PessoaFisica();
// eduardo.nome = "Eduardo Costa";
// eduardo.rendimento = 1900.00;
// eduardo.endereco = novoEndereco;

//Exibir os dados do Eduardo
// Console.WriteLine($"Nome: {eduardo.nome}");
// Console.WriteLine($"Rendimento: {eduardo.rendimento}");
// System.Console.WriteLine();

// Console.WriteLine($"Endereço:");

// Console.WriteLine($"Rua: {eduardo.endereco.logradouro}");
// Console.WriteLine($"Número: {eduardo.endereco.numero}");
// Console.WriteLine($"Comercial: {eduardo.endereco.comercial}");

//************* ENCONTRO REMOTO 5 *************
//Objetos Utilitários Genéricos
PessoaJuridica metodoPJ = new PessoaJuridica();
PessoaFisica metodoPF = new PessoaFisica();

// DADOS PESSOA JURÍDICA
Endereco novoEndSenai = new Endereco();
novoEndSenai.logradouro = "Rua Niterói";
novoEndSenai.numero = 180;
novoEndSenai.comercial = true;

PessoaJuridica senai = new PessoaJuridica();
senai.razaoSocial = "Serviço Nacional de Aprendizagem Industrial";
senai.cnpj = "12.123.444/0001-98";
// senai.cnpj = "12123444000198";
senai.nome = "SENAI";
senai.rendimento = 12000;
senai.endereco = novoEndSenai;


//Console.WriteLine($"Salário Líquido do Senai: {metodoPJ.PagarImposto(senai.rendimento)}");
// System.Console.WriteLine($"CNPJ {senai.cnpj} é válido? {metodoPJ.ValidarCnpj(senai.cnpj)}");


// DADOS PESSOA FÍSICA
// Endereço da pessoa física
Endereco endPf = new Endereco();
endPf.logradouro = "Rua de Casa";
endPf.numero = 123;
endPf.comercial = false;

PessoaFisica joao = new PessoaFisica();
joao.nome = "João da Silva";
joao.cpf = "12345670977";
joao.dataNascimento = "20/09/1990";
joao.rendimento = 6000;
joao.endereco = endPf;

// Calcula imposto 

// Console.WriteLine($"Salário Líquido do João: {metodoPF.PagarImposto(joao.rendimento)}");

// EXIBIÇÃO DE DADOS
System.Console.WriteLine("******* DADOS PESSOA JURÍDICA ******* ");
Console.WriteLine(@$"
Razão Social: {senai.razaoSocial}
Nome Fantasia: {senai.nome}
Endereço: {senai.endereco.logradouro}
Número: {senai.endereco.numero}
Endereço Comercial: {senai.endereco.comercial}
CNPJ: {senai.cnpj}
CNPJ Válido: {metodoPJ.ValidarCnpj(senai.cnpj)}
Rendimento Bruto: R$ {senai.rendimento}
Rendimento líquido: R$ {metodoPJ.PagarImposto(senai.rendimento)}
");


System.Console.WriteLine("******* DADOS PESSOA FÍSICA ******* ");
Console.WriteLine(@$"
Nome: {joao.nome}
Endereço: {joao.endereco.logradouro}
Número: {joao.endereco.numero}
Endereço Comercial: {joao.endereco.comercial}
Data de nascimento do João: {joao.dataNascimento}
Maior de idade: {metodoPF.ValidarDataNascimento(joao.dataNascimento)}
CPF: {joao.cpf}
Rendimento Bruto: R$ {joao.rendimento}
Rendimento líquido: R$ {metodoPF.PagarImposto(joao.rendimento)}
");



//************* ENCONTRO REMOTO 5 *************

// Console.WriteLine($"Nome Fantasia: {senai.nome}");
// Console.WriteLine($"Razão Social: {senai.razaoSocial}");
// Console.WriteLine($"CNPJ: {senai.cnpj}");
// Console.WriteLine($"Rendimento:R$ {senai.rendimento}");
// System.Console.WriteLine();

// Console.WriteLine($"\tEndereço:");

// Console.WriteLine($"Rua: {senai.endereco.logradouro}");
// Console.WriteLine($"Número: {senai.endereco.numero}");
// Console.WriteLine($"Comercial: {senai.endereco.comercial}");

//Outra forma de preencher os dados
// Console.WriteLine(@$"
// Nome Fantasia: {senai.nome}
// Razão Social: {senai.razaoSocial}");


//***********Substring****************
// string nome = "Eduardo";
// Console.WriteLine(nome);
// Console.WriteLine(nome.Substring(0,3));

// string cnpj = "12.345.678/0001-90";
// string cnpj2 = "12345678000190";
// System.Console.WriteLine(cnpj.Substring(11,4));
// System.Console.WriteLine(cnpj2.Substring(8,4));

// System.Console.WriteLine($"CNPJ TAMANHO: {cnpj.Length}");
// System.Console.WriteLine($"CNPJ TAMANHO: {cnpj2.Length}");

// //***********Regex************
// String data = "30/09/2022";
// bool dtValida = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// System.Console.WriteLine($"A data {data} é válida? {dtValida}");