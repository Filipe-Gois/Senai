// 1)criar classe "elevador": ok
// andar atual = 0 ok
// total de andares do predio (desconsiderar térreo) ok
// capacidade do elevador ok
// quantas pessoas estão presentes nele ok
// 1.1)métodos:
// inicializa: parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio) ok
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver 
// espaço); 

// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele); 

// Subir : para subir um andar (não deve subir se já estiver no último andar);

// Descer : para descer um andar (não deve descer se já estiver no térreo);

// Encapsular todos os atributos da classe (criar os métodos set e get).


using _1_refeito;

Elevador elevador = new Elevador();

elevador.Inicializar(elevador.maximoPessoas, elevador.totalAndares);