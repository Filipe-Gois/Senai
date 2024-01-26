import { StatusBar } from 'expo-status-bar';
import { Image, SafeAreaView, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';
import Label from './src/components/Label/Label';
import useLoadFonts from './src/components/useLoadFonts/useLoadFonts';
import * as SplashScreen from 'expo-splash-screen';
SplashScreen.preventAutoHideAsync();

export default function App() {

  const { fontsLoaded, onLayoutRootView } = useLoadFonts();

  if (!fontsLoaded)
    return null;


  return (
    <SafeAreaView onLayout={onLayoutRootView} style={styles.login__section}>
      <View style={styles.login__section}>

        <View style={styles.grid}>

          <View style={styles.login__box}>


            <View style={styles.logo__content}>
              <Image style={styles.image} source={require(`./src/assets/images/logo_hosp.png`)} />
              <Text style={styles.logo__contentText}>Login</Text>
            </View>

            <View style={styles.login__form}>
              <View style={styles.inputContainer}>
                <Label text={"Email"} />
                <TextInput placeholderTextColor={"#fff"} placeholder='Email' style={styles.input} />
              </View>


              <View style={styles.inputContainer}>
                <Label text={"Senha"} />
                <TextInput placeholderTextColor={"#fff"} placeholder='Senha' style={styles.input} />
              </View>

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
    backgroundColor: '#C8E7EF'


  },
  grid: {
    width: '80%',
    height: `100%`,
  },
  login__box: {
    flex: 1,
    width: '100%',
    height: '100%',
    gap: 50,
    justifyContent: 'center',
  },
  logo__content: {
    display: 'flex',
    alignItems: 'center',

  },
  logo__contentText: {
    fontSize: 30,
    color: '#002240',
    fontFamily: 'Poppins_Bold'
  },
  login__form: {
    display: 'flex',
    gap: 20
  },
  image: {
    width: 200,
    height: 200
  },
  input: {
    backgroundColor: '#90CDE2',
    borderRadius: 30,
    width: '100%',
    height: 40,
    padding: 20,
    alignSelf: 'center'
  },
  inputContainer: {
    gap: 10


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
