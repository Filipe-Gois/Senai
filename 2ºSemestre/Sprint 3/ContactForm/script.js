//1ºpasso: definir as variávei

//url da api local
let urlLocal = "http://localhost:3000/contatos"



//2º passo: criar a API local

//3º passo: chamar a API "VIACEP" para fazer a validação do cep informado

async function chamarApi() {
    let cep = document.getElementById('cep').value
    let urlCep = `https://viacep.com.br/ws/${cep}/json/`

    try {
        alert("Cep encontrado")
        let promise = await fetch(urlCep);
        let endereco = await promise.json();
        console.log(endereco);

        //exibe os dados buscados pelo cep dentro dos valores dos inputs
        exibirDados(endereco);
    }
    catch (error) {
        alert('Cep inválido!!')
        limparDados()
    }
}

// 4º passo: Criar método para exibição de dados de endereço
function exibirDados(e) {

    document.getElementById('rua').value = e.logradouro;
    document.getElementById('bairro').value = e.bairro;
    document.getElementById('cidade').value = e.localidade
    document.getElementById('UF').value = e.uf;
}
// 5º passo:criar método para limpar os campos do formulário

function limparDados() {
    document.getElementById('rua').value = ""
    document.getElementById('numero').value = ""
    document.getElementById('complemento').value = ""
    document.getElementById('bairro').value = ""
    document.getElementById('cidade').value = ""
    document.getElementById('UF').value = ""
}

// 6º passo:criar método para cadastrar um contato na lista

async function cadastrar(e) {
    e.preventDefault()
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


    try {
        let promise = await fetch(urlLocal, {
            body: JSON.stringify(dados),
            headers: { "Content-Type": "application/JSON" },
            method: "post",
        });

        let retorno = promise.json();
        console.log(retorno);
    }
    catch (error) {
        alert(error)
    }

}