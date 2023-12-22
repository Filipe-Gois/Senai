import React from "react";

const Numero = ({ num, setNum }) => {
  const handleSomar1 = () => setNum(num + 1);
  const handleSubtrair1 = () => (num > 0 ? setNum(num - 1) : num);

  return (
    <>
      <div>
        <p>Valor do state em número: {num}</p>
        <button
          onClick={() => {
            setNum(num + 10);
          }}
        >
          Somar
        </button>
      </div>

      <div>
        <input type="number" />

        <button onClick={handleSomar1}>Adicionar</button>
        <button onClick={handleSubtrair1}>Tirar</button>
        </div>
    </>
  );
};

export default Numero;
