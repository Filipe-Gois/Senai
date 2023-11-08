import React from "react";

const Nome = ({ nome, setNome }) => {
  console.log("nome :" + nome);

  return (
    <>
      <p>Nome:{nome}</p>
      <button
        onClick={() => {
          setNome((nome = "Fefe"));
        }}
      >
        Mostrar menu
      </button>

      <button
        onClick={() => {
          setNome((nome = "Filipe"));
        }}
      >
        Esconder menu
      </button>
    </>
  );
};

export default Nome;
