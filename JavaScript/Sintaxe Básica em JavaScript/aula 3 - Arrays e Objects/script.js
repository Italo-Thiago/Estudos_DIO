// // o que são vetores ou arrays

// // como declarar um array
// let array6 = ['string',1,true];
// console.log(array6);

// // pode guardar vários tipos de dados
let array5 = ['string', 1, true, ['array1'], ['array2'], ['array3'], ['array4']];
console.log(array5[0])
console.log(array5)

// forEach
// array5.forEach(function(item, index){console.log(item, index)});

// array5.push([]);
// console.log(array5);

// array5.pop();
// console.log(array5)

// array5.shift();
// console.log(array5);

// array5.unshift("novo item no início");
// console.log(array5);

// console.log(array5.indexOf(true));

// array5.splice(0, 3);
// console.log(array5);

// let novoArray = array5.slice(0, 3);
// console.log(novoArray);

// let object = { string: 'string', number: 1, boolean: true, array: ["array1"], objectInterno: {objectInterno: 'objeto interno'}};

// console.log(object.objectInterno);

// var string = object.string;
// console.log(string);

// var arrayInterno = object.array;
// console.log(arrayInterno);

// var { string, boolean, objectInterno} = object;
// console.log(string, boolean, objectInterno)