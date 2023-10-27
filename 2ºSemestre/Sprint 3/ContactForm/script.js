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
    document.getElementById('rua').value = ""
    document.getElementById('numero').value = ""
    document.getElementById('complemento').value = ""
    document.getElementById('bairro').value = ""
    document.getElementById('cidade').value = ""
    document.getElementById('UF').value = ""
}

function limparTodosOsDados() {
    document.getElementById('nome').value = ""
    document.getElementById('sobrenome').value = ""
    document.getElementById('email').value = ""

    document.getElementById('pais').value = ""
    document.getElementById('pais').value = ""
    document.getElementById('telefone').value = ""

    document.getElementById('cep').value = ""
    document.getElementById('rua').value = ""
    document.getElementById('numero').value = ""
    document.getElementById('complemento').value = ""
    document.getElementById('bairro').value = ""
    document.getElementById('cidade').value = ""
    document.getElementById('UF').value = ""

    document.getElementsByClassName('anotacoes').value = ""
}

// 6º passo:criar método para cadastrar um contato na lista

async function cadastrar(e) {
    e.preventDefault();
    const nome = document.getElementById('nome').value
    const sobrenome = document.getElementById('sobrenome').value
    const email = document.getElementById('email').value

    const pais = document.getElementById('pais').value
    const ddd = document.getElementById('pais').value
    const telefone = document.getElementById('telefone').value

    const cep = document.getElementById('cep').value
    const rua = document.getElementById('rua').value
    const numeroCasa = document.getElementById('numero').value
    const complemento = document.getElementById('complemento').value
    const bairro = document.getElementById('bairro').value
    const cidade = document.getElementById('cidade').value
    const uf = document.getElementById('UF').value

    const anotacoes = document.getElementsByClassName('anotacoes').value

    const dados = {
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
        bairro,
        cidade,
        uf,
        anotacoes
    }


    try {
        const promise = await fetch(urlLocal, {
            body: JSON.stringify(dados),
            headers: { "Content-Type": "application/json" },
            method: "post"
        });

        const retorno = promise.json();
        console.log(retorno);

        alert(`Cadastrado com sucesso!`)
    }
    catch (error) {
        alert(error)
    }

}