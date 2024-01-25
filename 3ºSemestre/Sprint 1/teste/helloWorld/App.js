import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { Button, Image, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';

export default function App() {
  const [inputValue, setInputValue] = useState('')
  return (
    <View style={styles.container}>

      <Image style={styles.image} source={{
        uri: 'https://i.imgflip.com/7p1t33.jpg'
      }} />


      <Text style={styles.paragrafo}>Hello, World!</Text>

      <Text>{inputValue}</Text>

      <TextInput
        style={styles.input}
        value={inputValue}
        onChange={(e) => setInputValue(e.target.value)}

      />

      <TouchableOpacity onPress={() => {
        alert(`Òlá, ${inputValue}.`)

        setInputValue('')

      }} color={'#000'} style={styles.botao}><Text style={styles.texto}>aperte!</Text></TouchableOpacity>


      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
    gap: 20
  },
  paragrafo: {
    color: '#000',
    fontSize: 30,
    textAlign: 'center'
  },
  input: {
    width: '80%',
    height: 40,
    borderWidth: 2,
    textDecorationColor: 'none',
    outline: 'none',
    padding: 10,
    borderRadius: 50


  },
  image: {
    width: 250,
    height: 250,
    borderRadius: 100
  },
  botao: {
    backgroundColor: 'red',
    width: '80%',
    height: 40,
    borderRadius: 50
  },
  texto: {
    color: 'white',
    fontSize: 30,
    textAlign: 'center',
    textTransform: 'uppercase'
  }
});


