//1ºpasso: definir as variávei

//url da api local
const urlLocal = "http://localhost:3000/contatospessoas"



//2º passo: criar a API local

//3º passo: chamar a API "VIACEP" para fazer a validação do cep informado

async function chamarApi() {
    const cep = document.getElementById('cep').value
    const urlCep = `https://viacep.com.br/ws/${cep}/json/`

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

    const campos = ['rua', 'numero', 'complemento', 'bairro', 'cidade', 'UF']

    campos.forEach(campo => {
        document.getElementById(campo).value = "";
    });


    //código antigo
    // document.getElementById('rua').value = ""
    // document.getElementById('numero').value = ""
    // document.getElementById('complemento').value = ""
    // document.getElementById('bairro').value = ""
    // document.getElementById('cidade').value = ""
    // document.getElementById('UF').value = ""
}

function limparTodosOsDados() {

    const campos = ['nome', 'sobrenome', 'email', 'pais', 'ddd', 'telefone', 'cep', 'rua', 'numero', 'complemento', 'bairro', 'cidade', 'UF', 'anotacoes']

    campos.forEach(campo => {
        document.getElementById(campo).value = '';
    });


    //código antigo
    // document.getElementById('nome').value = ""
    // document.getElementById('sobrenome').value = ""
    // document.getElementById('email').value = ""

    // document.getElementById('pais').value = ""
    // document.getElementById('ddd').value = ""
    // document.getElementById('telefone').value = ""

    // document.getElementById('cep').value = ""
    // document.getElementById('rua').value = ""
    // document.getElementById('numero').value = ""
    // document.getElementById('complemento').value = ""
    // document.getElementById('bairro').value = ""
    // document.getElementById('cidade').value = ""
    // document.getElementById('UF').value = ""

    // document.getElementsByClassName('anotacoes').value = ""
}

// 6º passo:criar método para cadastrar um contato na lista

async function Cadastrar(e) {
    e.preventDefault();

    const dados = {
        nome: extrairId('nome'),
        sobrenome: extrairId('sobrenome'),
        email: extrairId('email'),
        pais: extrairId('pais'),
        ddd: extrairId('ddd'),
        telefone: extrairId('telefone'),
        cep: extrairId('cep'),
        rua: extrairId('rua'),
        numeroCasa: extrairId('numero'),
        complemento: extrairId('complemento'),
        bairro: extrairId('bairro'),
        cidade: extrairId('cidade'),
        uf: extrairId('UF'),
        anotacoes: extrairId('anotacoes')
    };


    try {
        cadastrarContato(dados)
        alert(`Cadastrado com sucesso!`)
    }
    catch (error) {
        alert(error)
    }

}


//método responsável pelo cadastro de um contato
async function cadastrarContato(d) {
    try {
        await fetch(urlLocal, {
            body: JSON.stringify(d),
            headers: { "Content-Type": "application/json" },
            method: "post"
        });
    }
    catch (error) {
        throw (error)
    }
}


//Busca o valor de um input html pelo seu id. Criei para o código do objeto "dados" ficar mais limpo
function extrairId(id) {
    return document.getElementById(id).value;
}