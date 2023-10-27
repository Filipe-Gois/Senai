import React from "react";
import './Titulo.css' //importa as configurações do Titulo.css 


const Titulo = (props) => {
    return (
        <h1 className="titulo">Olá, {props.texto}. Seja bem-vindo!!</h1>
    );
}

export default Titulo;