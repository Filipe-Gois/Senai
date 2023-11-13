import axios from "axios";
import "./App.css";
import { apiExterna } from "./services/api";
import { useState } from "react";

function App() {

  const [pokemonList, setpokemonList] = useState([])


  axios
    .get("https://pokeapi.co/api/v2/pokemon")
    .then((response) => setpokemonList(response.data))
    .catch((err) => console.log(err));

  return (
    <div className="App">
      <h1>Olá, fefe!! </h1>


    </div>
  );
}

export default App;
