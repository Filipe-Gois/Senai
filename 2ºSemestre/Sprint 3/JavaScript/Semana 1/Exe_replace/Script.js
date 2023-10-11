function Rodar() {
    event.preventDefault()
    let nome = document.getElementById('nome').value;
    let nick = document.getElementById('nickname').value;



    let nomeMudado = nome.replace(nome, nick);



    alert(`Olá, ${nomeMudado}!`);

    document.getElementById('saudacao').innerHTML = `Olá, ${nomeMudado}` //Inserindo um texto personalizado no HTML

    // Dá p fazer desse jeito tmb
    // alert(`Olá, ${nome.replace(nome, nick)}`)
}