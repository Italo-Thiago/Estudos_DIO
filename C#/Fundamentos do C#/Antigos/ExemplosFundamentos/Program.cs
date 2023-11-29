(int, string, string, decimal) tupla = (1, "Italo", "Thiago", 1.70M);

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");


// List <string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++) {
//   Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString) {
//   Console.WriteLine($"Posição N° {contadorForeach} - {item}");
//   contadorForeach++;
// }

// int [] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// Console.WriteLine("Percorrendo um Array com o FOR");
// for(int i = 0; i < arrayInteiros.Length; i++) {
//   Console.WriteLine($"Posição N° {i} - {arrayInteiros[i]}");
// }

// Console.WriteLine("Percorrendo um Array com o FOREACH");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros) {
//   Console.WriteLine($"Posição N°{contadorForeach} - {valor}");
//   contadorForeach++;
// }
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu) {
//   Console.WriteLine("Digite a sua opção: ");
//   Console.WriteLine("1 - Cadastrar cliente");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar cliente");
//   Console.WriteLine("4 - Encerrar");
  
//   opcao = Console.ReadLine();
//   Console.Clear();

//   switch(opcao) {
//     case "1":
//       Console.WriteLine("Cadastro de cliente");
//       break;
//     case "2":
//       Console.WriteLine("Busca de cliente");
//       break;
//     case "3":
//       Console.WriteLine("Apagar cliente");
//       break;
//     case "4":
//       Console.WriteLine("Encerrar");
//       exibirMenu = false;
//       // Environment.Exit(0);
//       break;
//     default:
//       Console.WriteLine("Opção inválida");
//       break;
//   }
// }
// Console.Clear();
// Console.WriteLine("O programa se encerrou");

// int soma = 0, numero = 0;  // E possível declarar varias variáveis do mesmo tipo de uma vez só

// do {
//   Console.WriteLine("Digite um número (0 para parar)");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// Console.Clear();
// Console.Write("Digite o número que será multiplicado: ");
// int numeroMultiplicado = Convert.ToInt32(Console.ReadLine());
// Console.Write("Digite a quantidade de vezes que o número será multiplicado: ");
// int contador = Convert.ToInt32(Console.ReadLine());
// int i = 0;

// while (i <= contador) {
//   Console.WriteLine($"{i}° Execução: {numeroMultiplicado} x {i} = {numeroMultiplicado * i}");
//   i++;
// }

// for (int i = 0; i <= contador; i++ ){
//   Console.WriteLine($"{numeroMultiplicado} x {i} = {numeroMultiplicado * i}");
// }


// using C_.models

// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);

// int numero = 10;
// Console.WriteLine(numero);
// Console.WriteLine("Incrementar o 10");
// numero = numero + 1;
// numero++;
// Console.WriteLine(numero);
// numero--;
// Console.WriteLine(numero);

// bool choveu = true;
// bool estaTarde  = true;

// if (!choveu && ! estaTarde) {
//   Console.WriteLine("Vou pedalar");about:blank#blocked
// } else {
//   Console.WriteLine("Vou pedalar um outro dia");
// }

// bool possuiPresencaMinima = false;
// double media = 7.4;

// if (possuiPresencaMinima && media >= 7) {
//   Console.WriteLine("Aprovado!");
// } else {
//   Console.WriteLine("Reprovado!");
// }

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResposavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResposavel){
//   Console.WriteLine("Entrada liberada !!");
// } else {
//   Console.WriteLine("Entrada não liberada!!");
// // }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra) {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;
//   default:
//     Console.WriteLine("Não é uma vV")
// }

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//   Console.WriteLine("Vogal");
// } else {
//   Co
// // else if (letra == "o") {
// //   Console.WriteLine("Vogal");
// // }
// // else if (letra == "u") {
// //   Console.WriteLine("Vogal");
// // }
// // else {
// //   Console.WriteLine("Não é uma vogal")
// // }

// // int quantidadeEmEstoque = 10;
// // int quantidadeCompra = 4;
// // bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// // Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// // Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"Quantidade em estoque:  {quantidadeEmEstoque}");

// if (possivelVenda)
// {
//   Console.WriteLine("Venda realizada !!");
// }
// else
// {
//   Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
// }

// int a = 5; 
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;
// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();
//
// Console.WriteLine(a);
//
// // Cast - Casting
// int a = Convert.ToInt32("5");
// int b = int.Parse("5");
//
// Console.WriteLine(a);
// Console.WriteLine(b);



// int a = 10;
// int b = 20;
//
// int c = a + b;
//
// Console.WriteLine(c);
//
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
//
// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;
//
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);
//

// Pessoa p = new Pessoa();

// p.Nome = "Italo";
// p.Idade = 23;
// p.Apresentar();
