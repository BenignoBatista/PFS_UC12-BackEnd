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

Endereco novoEndSenai = new Endereco();
novoEndSenai.logradouro = "Rua Niterói";
novoEndSenai.numero = 180;
novoEndSenai.comercial = true;

PessoaJuridica senai = new PessoaJuridica();
senai.razaoSocial = "Serviço Nacional de Aprendizagem Industrial";
senai.cnpj = "12.123.444/0001-98";
senai.cnpj = "12123444000198";
senai.nome = "SENAI";
senai.rendimento = 100000.80;
senai.endereco = novoEndSenai;

PessoaJuridica metodoPJ = new PessoaJuridica();
System.Console.WriteLine($"CNPJ {senai.cnpj} é válido? {metodoPJ.ValidarCnpj(senai.cnpj)}");

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