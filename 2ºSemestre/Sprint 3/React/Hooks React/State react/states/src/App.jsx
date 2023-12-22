import { useState } from "react";
import "./App.css";
import Numero from "./Components/Numero";
import Nome from "./Components/Nome";

export default function App() {
  const [num, setNum] = useState(0);

  const [nome, setNome] = useState("Filipe")

  return (
    <>
      {/* <p>Valor do número em App: {num}</p>
      <Numero num={num} setNum={setNum} /> */}

      <Nome nome={nome} setNome={setNome}/>
    </>
  );
}
