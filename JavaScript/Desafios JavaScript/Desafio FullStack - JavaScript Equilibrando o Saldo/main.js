//Desafios JavaScript na DIO têm funções "gets" e "print" acessíveis globalmente:
//- "gets" : lê UMA linha com dado(s) de entrada (inputs) do usuário;
//- "print": imprime um texto de saída (output), pulando linha.

const saldoAtual = parseFloat(gets(500));
const valorDeposito = parseFloat(gets());
const valorRetirada = parseFloat(gets());

//TODO: Calcular o saldo atualizado de acordo com a descrição deste desafio.

function saldoAtualizado(saldo, deposito, retirada) {
  let saldoMaisDeposito = saldo + deposito;
  let saldoMenosRetirada = saldoMaisDeposito - retirada;
  return saldoMenosRetirada
}

//TODO: Imprimir o a saída de conforme a tabela de exemplos (uma casa decimal).
console.log(saldoAtual)