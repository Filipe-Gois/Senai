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

pessoas.forEach((element, i) => {
    console.log(`Pessoa: ${i + 1}: Nome: ${element.nome}, Idade: ${element.idade}`);
});

let carro = {
    Marca: "Ford",
    Modelo: "Ka",
    Ano: 2019,
    Proprietário: "Filipe"

};

let moto = {
    Marca: "Suzuki",
    Modelo: "2",
    Ano: 2047,
    Proprietário: "Filipe Góis"
};


let veiculos = [];

veiculos.push(carro, moto);

veiculos.forEach((element, i) => {
    //console.log(`Veículo ${i + 1}: ${element}.`); o console buga, trazendo o JSOn como "object object"
    console.log(element);
});