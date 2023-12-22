import React, { useEffect, useRef, useState } from "react";


export const testeRef1 = () => {
  const numberRef = useRef(0);

  //nao re-renderiza o componente
  useEffect(() =>  {
    numberRef.current = Math.random();
  });

  return (
    <>
      <h1>O numero do useRef é {numberRef.current}</h1>
    </>
  );
};


export const testeRef2 = () => {
  const buttonRef = useRef();

  const [count, setCount] = useState(0);
  const [number, setNumber] = useState(0);
  useEffect(() => {
    //referencia para elementos de DOM
    //aqui ele já é um elemento do DOM, ou seja, dá p usar métodos do DOM, Ex: .click()

    // buttonRef.current: mesma coisa do getElementBy...
    console.log(buttonRef.current.click());
  }, []);

  return (
    <>
      <h1>O number é {number}</h1>
      <h1>O contador é {count}</h1>
      <button ref={buttonRef}></button>
    </>
  );
};

export const testeRef3 = () => {
  const [count, setCount] = useState(0);
  const oldCountRef = useRef(0);

  useEffect(() => {
    oldCountRef.current = count;
  }, [count]);

  return (
    <>
      <h1>O contador é {count}</h1>
      <h2>O contador anterior era: {oldCountRef.current}</h2>
      <button ref={buttonRef}></button>
    </>
  );
};
