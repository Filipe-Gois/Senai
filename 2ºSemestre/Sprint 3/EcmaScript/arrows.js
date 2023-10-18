// const somar = function name(x, y) {
//     return x + y
// }

//mesma coisa (função anônima)
// const somar = function (x, y) {
//     return x + y
// }


//arrow function
const somar = (x, y) => {
    return x + y;
}
console.log(somar(50, 10));



//se só tiver um parâmetro, dá p tirar os ()
const dobro = x => {
    return x * 2;
}

//fazer assim caso a arrow function só tiver 1 linha
//a "=> representa o "return"
const dobro2 = x => x * 2;

console.log(dobro(10));

//é obrigatório colocar os () caso a function não tenha parametros
const boaTtarde = () => { console.log('Boa') }

boaTtarde()

const convidados = ["Filipe", "Murilo", "Guilherme", "Bigas"]

convidados.forEach((e, i) => console.log(`${i + 1}º ${e}`));