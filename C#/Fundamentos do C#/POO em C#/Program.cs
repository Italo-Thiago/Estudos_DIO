
using POO_em_C_.models;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("----------------");

estados.Remove("BA"); // Você so consegue mudar uma chave removendo ela antes.
estados["SP"]= "São Paulo - valor alterado"; // Você pode mudar o "Valor" sempre que quiser.

// estados.Add("BA", "Bahia") Erro de exceção a chave deve ser única.

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA"; // Crie uma variável que ira guardar o valor da Key a ser procurada
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave)) {// Se conter a Key ira dar verdadeiro
  Console.WriteLine($"Valor existente: {chave}");
} else {
  Console.WriteLine($"Valor não existe, É seguro adicionar a chave: {chave}");
}

Console.WriteLine(estados['MG']); // E assim que você procura um valor no dicionario usando o Key

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha){
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach(int item in pilha){
//   Console.WriteLine(item);
// }

// queue<int> fila = new queue<int>();

// fila.enqueue(2);
// fila.enqueue(4);
// fila.enqueue(6);
// fila.enqueue(8);

// foreach(int item in fila) {
//   console.writeline(item);
// }

// console.writeline($"removendo o elemento: {fila.dequeue()}");
// fila.enqueue(10);

// foreach(int item in fila) {
//   console.writeline(item);
// }

// new ExemploExcecao().Metodo1();
// try {
//   string[] linhas = File.ReadAllLines("arquivos/arquivoL_eitura.txt");
//   foreach(string linha in linhas) {
//     Console.WriteLine(linha);
//   }
// } catch(FileNotFoundException ex) {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado . {ex.Message}");
// }
// catch(DirectoryNotFoundException ex) {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch(Exception ex) {
//   Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally {
//   Console.WriteLine("Chegou até aqui");
// }






























// using System.Globalization;

// string dataString = "2022-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(
//   dataString, // variável que ira receber o cast
//   "yyyy-MM-dd HH:mm", // formato
//   CultureInfo.InvariantCulture, // provider = cultura, estática
//   DateTimeStyles.None, // DataTimeStyles = estilo
//   out DateTime data // variável que ira guardar o valor depois do cast.
//   );

// if (sucesso) {
//   Console.WriteLine($"Conversão com sucesso! Data: {data}");
// } else {
//   Console.WriteLine($"{dataString} não é uma data válida");
// }

// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("yyyy-MM-dd HH:mm"));

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;
// Console.WriteLine(valorMonetario.ToString("C5"));
// // Console.WriteLine(valorMonetario.ToString("C2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);

// Pessoa p1 = new Pessoa(nome:"Italo", sobrenome:"Thiago");


// Pessoa p2 = new Pessoa(nome:"Fulano", sobrenome:"Silva");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();