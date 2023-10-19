//destructuring: extrair algo específico de um objeto para uma variável

const convidados = ["Filipe", "Murilo", "Guilherme", "Bigas"]


const camisa = {
    descricao: "Camisa Nike",
    marca: "Nike",
    tamanho: "M",
    preco: 199.99,
    cor: "Preta",
    promocao: false
}
//jeito padrão
// const desc = camisa.descricao
// const preco = camisa.preco

const { descricao, preco, promocao } = camisa

console.log(`
    Produto: ${descricao}
    Preço: ${preco}
    Promoção: ${promocao ? "Sim" : "Não"}
`);



//crie um objeto evento com as propriedades
/*
dataEvento,
descricaoEvento,
tituloEvento,
presencaEvento,
comentarioEvento
*/

const evento = {
    dataEvento: new Date(),
    descricaoEvento: "Será ensinado Java.",
    tituloEvento: "Intensivão de Java",
    presencaEvento: true,
    comentarioEvento: "MUITO LEGAL, AMO ESTES EVENTOS!!!!"
}

const { dataEvento, descricaoEvento, tituloEvento, presencaEvento, comentarioEvento } = evento

console.log(`

    Evento: ${tituloEvento}
    Data do evento: ${dataEvento}
    Descrição do evento: ${descricaoEvento}
    Presença: ${presencaEvento ? "Confirmado" : "Não confirmado"}
    Comentário do evento: ${comentarioEvento}
`);


/*
rest operator:
const { dataEvento, descricaoEvento, tituloEvento, ...resto} = evento

console.log(`

    Evento: ${tituloEvento}
    Data do evento: ${dataEvento}
    Descrição do evento: ${descricaoEvento}
    Presença: ${resto.presencaEvento ? "Confirmado" : "Não confirmado"}
    Comentário do evento: ${resto.comentarioEvento}
`);


"...resto"

transforma todas as outras propriedades do objeto "evento" em propriedades do objeto "resto"
*/