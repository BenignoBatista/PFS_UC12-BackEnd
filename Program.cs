using System;
using System.Text.RegularExpressions;
// criar uma pessoa física
// preencher o nome
// imprimir no console

using ATIV_UC12_SA2_ER2.Classes;
//Objetos Utilitários Genéricos
PessoaJuridica metodoPJ = new PessoaJuridica();
PessoaFisica metodoPF = new PessoaFisica();
List<PessoaFisica> listaPf = new List<PessoaFisica>();//Cria uma lista de pessoa física (Array de objetos)

//************* ENCONTRO REMOTO 6 *************
//Cabeçalho de boas vindas
System.Console.WriteLine(@$"
=========================================================
|          Bem vindo ao sistema de cadastro de          |
|              Pessoas Físicas e Jurídicas              |
=========================================================
");
Utils.BarraCarregamento("Iniciando o Sistema", 3, 500);

// ************ Menu de Opções **************
string? opcao;
do
{
    System.Console.WriteLine(@$"
=========================================================
|          Escolha uma das seguintes opções             |
---------------------------------------------------------
|              1 - Pessoas Físicas                      |
|              2 - Pessoas Jurídicas                    |
|                                                       |
|              0 - Sair                                 |
=========================================================
");

    System.Console.Write($"OPÇÃO: ");
    opcao = Console.ReadLine(); // Espera o usuário digitar
    Console.Clear();

    switch (opcao)
    {
        case "1": //Pessoa Física
                  // Utils.BarraCarregamento("Cadastrando", 3, 300);
            string? opcaoPf;
            do  //Submenu pessoa física
            {
                Console.Clear();
                System.Console.WriteLine(@$"
=========================================================
|          Escolha uma das seguintes opções             |
---------------------------------------------------------
|              1 - Cadastrar Pessoa Física              |
|              2 - Listar Pessoa Física                 |
|                                                       |
|              0 - Voltar ao menu anterior              |
=========================================================
");

                System.Console.Write($"OPÇÃO: ");
                opcaoPf = Console.ReadLine();//espera o usuário digitar

                switch (opcaoPf)
                {
                    case "1"://Cadastrar pessoa física
                             //Endereço
                        Endereco endPf = new Endereco();
                        Console.WriteLine($"Qual é o endereço? ");
                        endPf.logradouro = Console.ReadLine();
                        Console.WriteLine($"Qual é o número? ");
                        endPf.numero = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Endereço é comecial? S/N");
                        string enderecoComercial = Console.ReadLine();
                        if (enderecoComercial.ToUpper() == "S")
                        {
                            endPf.comercial = true;
                        }
                        else
                        {
                            endPf.comercial = false;
                        }

                        //Dados pessoais
                        PessoaFisica novaPf = new PessoaFisica();
                        Console.WriteLine($"Qual é o nome? ");
                        novaPf.nome = Console.ReadLine();
                        Console.WriteLine($"Qual é o CPF? ");
                        novaPf.cpf = Console.ReadLine();
                        Console.WriteLine($"Qual é sua data de nascimento? Ex.: 25/04/1988 ");
                        novaPf.dataNascimento = Console.ReadLine();
                        Console.WriteLine($"Qual é seu rendimento? ");
                        novaPf.rendimento = double.Parse(Console.ReadLine());//converte texto pra double
                        novaPf.endereco = endPf;

                        // guarda a pessoa física da lista
                        listaPf.Add(novaPf);
                        break;

                    case "2":
                        //Listar pessoa física
                        Console.WriteLine($"Listar pessoa física");

                        if (listaPf.Count > 0) //Lista
                        {
                            foreach (PessoaFisica pf in listaPf)//imprimi cada pessoa da lista
                            {
                                Console.WriteLine(@$"
            Nome: {pf.nome}
            Endereço: {pf.endereco.logradouro}
            Número: {pf.endereco.numero}
            Endereço Comercial: {pf.endereco.comercial}
            Data de nascimento: {pf.dataNascimento}
            Maior de idade: {metodoPF.ValidarDataNascimento(pf.dataNascimento)}
            CPF: {pf.cpf}
            Rendimento Bruto: R$ {pf.rendimento}
            Rendimento líquido: R$ {metodoPF.PagarImposto(pf.rendimento)}
            ");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Lista Vazia");
                            Console.ResetColor();
                            Thread.Sleep(2000);//Espera 2 segundos e volta para o submenu
                        }

                        break;

                    case "0":
                        //Voltar ao menu anterior
                        Console.WriteLine($"Voltar ao menu anterior");

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Opção Inválida do submenu");
                        Console.ResetColor();
                        break;
                }

                System.Console.Write("Digite ENTER para continuar SUBMENU...");

            } while (opcaoPf != "0");





            //Parada no sistema
            System.Console.Write($"Digite ENTER para continuar ...");
            Console.ReadLine();
            Console.Clear();
            break;

        case "2": //Pessoas Jurídica
                  //Cadastro

            //Parada no sistema
            System.Console.Write($"Digite ENTER para continuar ...");
            Console.ReadLine();
            Console.Clear();
            break;

        case "0": // Sair
            System.Console.WriteLine("Obrigado por utilizar nosso sistema!!!");
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Opção Inválida, escolha outra opção");
            Console.ResetColor();
            break;
    }

} while (opcao != "0");
/*
// Endereço da pessoa física
        Endereco endPf = new Endereco();
        endPf.logradouro = "Rua de Casa";
        endPf.numero = 123;
        endPf.comercial = false;
        //Cadastrando Pessoa Física
        PessoaFisica joao = new PessoaFisica();
        joao.nome = "João da Silva";
        joao.cpf = "12345670977";
        joao.dataNascimento = "20/09/1990";
        joao.rendimento = 6000;
        joao.endereco = endPf;
        //Exibir dados
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
            */

/*
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

// Exibir Dados
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
*/





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



//Console.WriteLine($"Salário Líquido do Senai: {metodoPJ.PagarImposto(senai.rendimento)}");
// System.Console.WriteLine($"CNPJ {senai.cnpj} é válido? {metodoPJ.ValidarCnpj(senai.cnpj)}");


// Calcula imposto 

// Console.WriteLine($"Salário Líquido do João: {metodoPF.PagarImposto(joao.rendimento)}");



//System.Console.WriteLine("******* DADOS PESSOA FÍSICA ******* ");




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