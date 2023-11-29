using System.Data;
using System.Text;
using System.Text.Json;

int a = 10;

int b = a;
b = 60;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");

// using New_Project.models;

// Pessoa p1 = new Pessoa("Italo", "Thiago");
// Pessoa p2 = p1;
// p2.Nome = "Leonardo";


// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p1: {p2.NomeCompleto}");

// int numero = 20;
// bool par = false;

// // IF Ternário
// par = numero.EhPar();

// string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
// Console.WriteLine(mensagem);

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString= new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);


// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// string jsonString = File.ReadAllText("archives/vendas.json");

// // Console.WriteLine(jsonString);

// List<Venda> listaVenda = JsonSerializer.Deserialize<List<Venda>>(jsonString);

// var listaAnonima = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonima) {
// 	Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

// foreach (Venda venda in listaVenda) {
//   Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// } 

// DateTime dataAtual = DateTime.Now;

// var options = new JsonSerializerOptions
// {
//   WriteIndented = true,
//   // Esta forma abaixo e a forma insegura de fazer a conversão para UTF-8, procure outra sé necessário
//   Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
// };

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonSerializer.Serialize(listaVendas,options);

// File.WriteAllText("archives/vendas.json", serializado);

// Console.WriteLine(serializado);

// int numero = 15;
// bool ehPar = false;

// // If normal
// if (numero % 2 == 0) {
//   Console.WriteLine($"O número {numero} é par");
// } else {
//   Console.WriteLine($"O numero {numero} e impar");
// }
// // If ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
// // ehPar se verdadeiro "par" senão falso "ímpar"

// using New_Project;

// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("arquivosLeitura.txt");

// if (sucesso) {
//   // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//   foreach (string linha in linhasArquivo) {
//     Console.WriteLine(linha);
//   }
// } else {
//   Console.WriteLine("Não foi possível ler o arquivo");
// }

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Italo", "Thiago", 1.70M);

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Italo", "Thiago", 1.80M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Italo", "Thiago", 1.80M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");