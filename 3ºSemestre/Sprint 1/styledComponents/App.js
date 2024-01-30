import { StatusBar } from 'expo-status-bar';
import { SafeAreaView, StyleSheet, Text, View, TouchableOpacity } from 'react-native';
import { useEffect, useState } from 'react';
import { Container } from './src/components/container/Container';
import { Title, TitleWhite } from './src/components/title/Title';
import { ButtonDecrement, ButtonIncrement } from './src/components/button/Button';
import { ThemeProvider } from 'styled-components';
import { Theme } from './src/Theme';



export default function App() {
  const [count, setCount] = useState(0)


  const increment = () => setCount(count + 1)
  const decrement = () => count > 0 && setCount(count - 1)


  useEffect(() => { console.warn("Clicou " + count + " vezes!") }, [count])


  return (
    <ThemeProvider theme={Theme}>

      <Container>
        <Title>Número: {count}</Title>
        <ButtonIncrement onPress={increment}>

          <TitleWhite>
            Aumentar!
          </TitleWhite>


        </ButtonIncrement>

        <ButtonDecrement onPress={decrement}>
          <TitleWhite>
            Diminuir!
          </TitleWhite>
        </ButtonDecrement>


        <StatusBar style="auto" />
      </Container>

    </ThemeProvider>
  );
}

