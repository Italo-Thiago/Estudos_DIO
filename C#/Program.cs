using ExemploFundamentos.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeEmEstoque;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda realizada !!");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}

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
