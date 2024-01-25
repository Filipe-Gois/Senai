import { StatusBar } from 'expo-status-bar';
import { Image, SafeAreaView, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';

export default function App() {
  return (
    <SafeAreaView style={styles.login__section}>
      <View style={styles.login__section}>

        <View style={styles.grid}>

          <View style={styles.login__box}>


            <View style={styles.logo__content}>
              <Image style={styles.image} source={require(`./src/assets/images/logo_hosp.jpg`)} />
              <Text style={styles.logo__contentText}>Login</Text>
            </View>

            <View style={styles.login__form}>
              <TextInput placeholderTextColor={"#fff"} placeholder='Email' style={styles.input} />
              <TextInput placeholderTextColor={"#fff"} placeholder='Senha' style={styles.input} />


              <TouchableOpacity style={styles.button}>

                <Text style={styles.textButton}>Entrar</Text>

              </TouchableOpacity>
            </View>
          </View>
        </View>




        <StatusBar style="auto" />
      </View>
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  login__section: {
    width: '100vw',
    height: '100%',
    flex: 1,
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',


  },
  grid: {
    width: '80%',
    height: `100%`,
  },
  login__box: {
    flex: 1,
    width: '100%',
    height: '100%',

    justifyContent: 'space-evenly',
  },
  logo__content: {
    display: 'flex',
    alignItems: 'center',
    gap: 40
  },
  logo__contentText: {
    fontSize: 30
  },
  login__form: {
    display: 'flex',
    gap: 20
  },
  image: {
    width: 100,
    height: 100
  },
  input: {
    backgroundColor: '#90CDE2',
    borderRadius: 30,
    width: '100%',
    height: 40,
    padding: 20,
    alignSelf: 'center'


  },
  button: {
    width: '100%',
    height: 40,
    backgroundColor: '#002240',
    justifyContent: 'center',
    borderRadius: 20
  },
  textButton: {
    color: '#fff',
    textAlign: 'center',
    fontSize: 20
  }

});
