function Rodar() {
event.defaultPrevented();
    let nome = document.getElementById('nome').value;
    let nick = document.getElementById('nickname').value;

    let nomeMudado = nome.replace("Aluno");

    console.log(`Olá, ${nomeMudado}`);
}