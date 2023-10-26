const urlLocal = "http://localhost:3000/contatos"


let nome = document.getElementById('nome').value
let sobrenome = document.getElementById('sobrenome').value
let email = document.getElementById('email').value

let pais = document.getElementById('pais').value
let ddd = document.getElementById('pais').value
let telefone = document.getElementById('telefone').value

let cep = document.getElementById('cep').value
let rua = document.getElementById('rua').value
let numeroCasa = document.getElementById('numero').value
let complemento = document.getElementById('complemento').value
let bairro = document.getElementById('bairro').value
let cidade = document.getElementById('cidade').value
let uf = document.getElementById('UF').value

let anotacoes = document.getElementsByClassName('anotacoes').value

let dados = {
    nome,
    sobrenome,
    email,
    pais,
    ddd,
    telefone,
    cep,
    rua,
    numeroCasa,
    complemento,
    bairro, cidade,
    uf,
    anotacoes
}


async function chamarApi() {
    const url = `https://viacep.com.br/ws/${cep}/json/`;
    try {
        const promise = await fetch(url);
        const endereco = await promise.json();

        alert('Cep encontrado!!')
        console.log(endereco);
        exibirEndereco(endereco);
    }
    catch (error) {
        alert('Cep inválido!!')
    }
}

function cadastrar(dados) {

}

function exibirEndereco(e) {
    rua = e.logradouro
    bairro = e.bairro
    cidade = e.cidade
    uf = e.uf
}

function limparDados() {

}

