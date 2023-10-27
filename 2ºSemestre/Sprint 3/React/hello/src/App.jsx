import './App.css';
import Titulo from './components/Titulo/Titulo';
import Card from './components/CardEvento/Card'

function App() {
  return (
    <div className="App">
      <h1>Hello React</h1>
      <Titulo texto="Filipe" />
      <Titulo texto="Góis" />
      <Titulo texto="Guilherme" />

      <Card titulo="Titulo" descricao="Breve descrição do evento, pode ser um paragrafo pequenoBreve descrição do evento, pode ser um paragrafo pequeno.Breve descrição do evento, pode ser um paragrafo pequeno."/>

      <Card titulo="Titulo" descricao="Breve descrição do evento, pode ser um paragrafo pequenoBreve descrição do evento, pode ser um paragrafo pequeno.Breve descrição do evento, pode ser um paragrafo pequeno."/>

      <Card titulo="Titulo" descricao="Breve descrição do evento, pode ser um paragrafo pequenoBreve descrição do evento, pode ser um paragrafo pequeno.Breve descrição do evento, pode ser um paragrafo pequeno."/>
      
      <Card titulo="Titulo" descricao="Breve descrição do evento, pode ser um paragrafo pequenoBreve descrição do evento, pode ser um paragrafo pequeno.Breve descrição do evento, pode ser um paragrafo pequeno."/>
    </div>
    

  );
}

export default App;
