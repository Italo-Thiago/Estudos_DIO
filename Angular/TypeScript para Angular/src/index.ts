// // type heroi = {
// //   name: string;
// //   vulgo: string;
// // }

// // function printaObjetos(pessoa: heroi) {
// //   console.log(pessoa);
// // }

// // printaObjetos({
// //   name: "Bruce Wayne",
// //   vulgo: "Batman",
// // });

// // Tipos primitivos: boolean, number, string
//   let ligado: boolean = false;
//   let nome: string = "Italo";
//   let idade: number = 30;
//   let altura: number = 1.9;

// // Tipos especiais null, undefined,
//   let nulo: null = null;
//   let indefinido: undefined = undefined;

// // Tipos abrangentes: any, void,
//   let retorno: void;
//   let qualquertipo:any = false;

// // Objeto - sem previsibilidade
//   let produto:object = {
//     name: "Italo",
//     cidade: "RJ",
//     idade: 22,
//   };

// // Objeto tipado - com previsibilidade
//   type ProdutoLoja = {
//     nome: string;
//     preco: number;
//     unidade: number;
//   }

//   let produtoLoja: ProdutoLoja = {
//     nome: "Tênis",
//     preco: 89.99,
//     unidade: 5,
//   };

// // Arrays
//   let dados: string[] = ["Italo", "Thiago", "Silva"];
//   let dados2: Array<string> = ["Gustavo", "Antonio", "Campinas"];

//   let infos: (string | number)[] = ["Italo", 42, "Adriano", 8];

// // Tuplas - Vetor de MultiTipes porem tendo um lugar certo para cada coisa.
//   let boleto:[string, number, number] = ["Agua Conta", 199,9, 884223089375];

// // Datas
//   let aniversario:Date = new Date("2022-12-01 05:00");
//   console.log(aniversario.toString());

// //função
// function addNumber(x:number, y:number):number {
//   return x + y;
// }

// function addToHello(name:string):string {
//   return `Hello ${name}`;
// }

// let soma: number = addNumber(4, 7);
// console.log(addToHello("Italo"));

// // funções com mais de um tipo
// //function CallToPhone(phone: number | string):any {
// function CallToPhone(phone: number | string): number | string {
//   return phone;
// }

// console.log(CallToPhone(381708373));

// // funções assíncronas
// async function getDatabase(id: number): Promise<number | string> {
//   return "Italo";
// }

//interfaces (type X interface)
// type robot = {
//   readonly id: number | string;
//   name: string;
// }

// interface robot2 {
//   readonly id: number | string;
//   name: string;
//   sayHello(): string;
// }

// const bot1: robot = {
//   id: 1,
//   name: "Megamen"
// }

// const bot2: robot2 = {
//   id: 1,
//   name: "Megamen",
//   sayHello: function (): string {
//     throw new Error("Function not implemented.");
//   }
// }

// class Pessoa implements robot {
//   id: string | number;
//   name: string;

//   constructor(id: string | number, name: string) {
//     this.id = id;
//     this.name = name;
//   }

//   sayHello(): string {
//     return `Hello ${this.name}`;
//   }
// }

// const p = new Pessoa(1, "Gostoso");
// console.log(p.sayHello());

/*
data modifiers
public (E o comportamento padrão, não faz diferença por ou não)
private (Somente pode ser alterada pro dentro da classe)
protected (Somente a classe e subclasses consegues enxergar)
*/

// classes (Formas)
// class Character {
//   private name: string;
//   strength: number;
//   skill: number;

//   constructor(name: string, strength: number, skill: number) {
//     this.name = name;
//     this.strength = strength;
//     this.skill = skill;
//   }

//   attack(): void {
//     console.log(`Attack! with ${this.strength} points`);
//   }
// }

// // Character: superclass
// // Magician: subclass
// class Magician extends Character {
//   magicPoints: number;
//   constructor(
//     name: string,
//     strength: number,
//     skill: number,
//     magicPoints: number
//   ) {
//     super(name, strength, skill);
//     this.magicPoints = magicPoints;
//   }
// }

// const p1 = new Character("Ryu", 10, 98);
// const p2 = new Magician("Mago", 9, 30, 100);
// p1.attack();
// console.log(p2);

// Generics, e uma forma de deixar em aberto o tipo de determinada função e passar posteriormente via parâmetro.
function concatArray<T>(...itens: T[]): T[]{
  return new Array().concat(...itens);
}; 

const numArray = concatArray<number[]>([1,5], [3]);
const stgArray = concatArray<string[]>(["Nemesis", "Doctor X"], ["Resident Evil"]);
console.log(numArray);
console.log(stgArray);