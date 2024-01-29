import { SafeAreaView, StyleSheet, Text, View, StatusBar, FlatList } from 'react-native';
import Person from './src/components/Person/Person';

//import das fonts
import { useFonts, Poppins_300Light } from '@expo-google-fonts/poppins';

import { SingleDay_400Regular } from "@expo-google-fonts/single-day"

import Game from './src/components/Game';


export default function App() {
  let [fontsLoaded, fontError] = useFonts({
    Poppins_300Light,
    SingleDay_400Regular
  });

  if (!fontsLoaded && !fontError) {
    return null;
  }

  const peopleList = [{

    id: "1",
    name: "Filipe Góis",
    age: "17"
  },
  {
    id: "2",
    name: "Gui",
    age: "19"
  },
  {
    id: "3",
    name: "Predo",
    age: "20"
  }]

  const gamesList = [{
    id: '1',
    name: 'God Of War',
    desenvolvedora: 'Sony',
    dataLancamento: '14/01/2007'
  }, {
    id: '2',
    name: 'Valorant',
    desenvolvedora: 'Riot',
    dataLancamento: '22/11/2020'
  }, {
    id: '3',
    name: 'Amongus',
    desenvolvedora: 'Amongus',
    dataLancamento: '19/07/2022'
  },]


  return (
    <SafeAreaView style={styles.container}>
      <StatusBar style="auto" />

      {/* flatList */}
      <FlatList

        data={peopleList}

        keyExtractor={item => item.id}

        renderItem={({ item }) => (
          <Person name={item.name} age={item.age} />
        )}
      />

      <FlatList
        data={gamesList}

        keyExtractor={item => item.id}
        renderItem={({ item }) => (

          <Game
            name={item.name}
            desenvolvedora={item.desenvolvedora}
            dataLancamento={item.dataLancamento}
          />
        )} />






      {/* <Person name={`Filipe Góis`} age={17} /> */}
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#000',
    alignItems: 'center',
    justifyContent: 'center',

  },
});
