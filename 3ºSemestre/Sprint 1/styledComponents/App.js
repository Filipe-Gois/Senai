import { StatusBar } from 'expo-status-bar';
import { SafeAreaView, StyleSheet, Text, View, TouchableOpacity } from 'react-native';
import { useEffect, useState } from 'react';


export default function App() {
  const [count, setCount] = useState(0)


  const increment = () => setCount(count + 1)
  const decrement = () => count > 0 && setCount(count - 1)


  useEffect(() => { console.warn("Clicou " + count + " vezes!") }, [count])


  return (
    <SafeAreaView style={styles.container}>
      <Text>Contador: {count}</Text>

      <TouchableOpacity style={{ ...styles.buttonDecremento, backgroundColor: 'blue' }} onPress={increment}>

        <Text style={styles.text}>
          Aumentar!
        </Text>

      </TouchableOpacity>

      <TouchableOpacity style={styles.buttonDecremento} onPress={decrement}>

        <Text style={styles.text}>
          Diminuir!
        </Text>

      </TouchableOpacity>
      <StatusBar style="auto" />
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  buttonDecremento: {
    backgroundColor: 'red',
    width: 100,
    height: 40,
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
    borderRadius: 50,
    margin: 20
  },
  text: {
    color: '#fff'
  }

});
