let filipe = {

    nome: "Filipe",
    idade: 16,
    altura: 1.7,
    peso: 59.9,

};

filipe.peso = 59.9 //propriedades são dinâmicas no JS, se n existir a propriedade, ele cria automaticamente

//console.log(filipe);

let gui = new Object();
gui.nome = "Guilherme";
gui.idade = 18;
gui.peso = 80,
gui.altura = 1.78
//console.log(gui);

let pessoas = [];
//let pessoas = new Array()
pessoas.push(filipe, gui);

//console.log(pessoas);

pessoas.forEach((element,i) => {
    console.log(`Pessoa: ${i+1}: Nome: ${element.nome}, Idade: ${element.idade}`);
});