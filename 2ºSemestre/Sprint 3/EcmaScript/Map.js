//filter, - retorna um novo array apenas com os elementos que atendem a uma condição
//map, - retorna um novo arrya modificado
//reduce, - possui caracteristica de juntar as coisas - retorna somente um número
//foreach - retorna void

const numeros = [1, 2, 3, 15, 10, 164, 2555]

//map:
//const dobro = numeros.map((n) => n * 2)

// console.log(numeros);
// console.log(dobro);

//filter
//
//const maior10 = numeros.filter((e) => e > 10)

//console.log(maior10);
//-----
const comentarios = [
    { comentario: "Muito bom!!", exibe: true },
    { comentario: "Muito merda", exibe: false },
    { comentario: "ótimo!", exibe: true }
]

const comentariosOk = comentarios.filter((c) => {
    return c.exibe === true
});

comentariosOk.forEach(e => console.log(e.comentario));


//reduce
//valorInicial: é o 2
//n: cada objeto dentro do array "numeros" 
//o resultado será: 1+ 2+ 3+ 15+ 10+ 164+ 2555 = 2752
const soma = numeros.reduce((valorInicial, n) => {
    return valorInicial + n;
}, 2)

console.log(soma);