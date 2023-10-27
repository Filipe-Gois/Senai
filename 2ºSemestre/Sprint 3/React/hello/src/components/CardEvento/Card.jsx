import React from 'react';
import './Card.css'


const Card = ({ titulo, descricao, desabilitar, textoLink }) => {
    return (
        <div className="card-evento">
            <h3 className="card-evento__titulo">{titulo}</h3>
            <p className="card-evento__text">{descricao}</p>
            <a href="" className="card-evento__conection">Conectar</a>
        </div>
    );
}

export default Card;


