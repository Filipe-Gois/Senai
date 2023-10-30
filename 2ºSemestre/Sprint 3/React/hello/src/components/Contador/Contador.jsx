//USANDO STATE

import React, { useState } from "react";
import "./Contador.css";

const Contador = () => {

    //"setContador" pode ser qualquer coisa. É uma função que altera o valor do "contador". useState(0)  o parâmetro é onde começa o contador
    const [Contador, setContador] = useState(0);

    const handleIncrementar = () => setContador(Contador + 1);

    const handleDecrementar = () =>  Contador > 0 ? setContador(Contador-1) : Contador




// function handleIncrementar() {
//     setContador(Contador + 1)
// }

return (
    <>
        <p>{Contador}</p>
        {/* //NÃO COLOCAR OS PARENTESES. Caso precise colcoar parâmetros, encapsular o método em uma arrow function */}
        <button onClick={() => { handleIncrementar() }}>Incrementar</button>

        <button onClick={() => { handleDecrementar() }}>Decrementar</button>
    </>
);
}

export default Contador;