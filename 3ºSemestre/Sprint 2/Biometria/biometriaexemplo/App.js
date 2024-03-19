import { StatusBar } from "expo-status-bar";
import { Alert, StyleSheet, Text, TouchableOpacity, View } from "react-native";

import * as LocalAuthentication from "expo-local-authentication";
import AsyncStorage from "@react-native-async-storage/async-storage";
import { useEffect, useState } from "react";
import moment from "moment";

const App = () => {
  const [dateHistory, setDateHistory] = useState({}); //salvar objeto com historico
  const [authenticated, setAuthenticated] = useState(false); //salvar o status de autenticado
  const [isBiometricSupported, setIsBiometricSupported] = useState(false);

  //função para verificar se o aparelho tem suoprte a biometria
  const CheckExistAuthentications = async () => {
    const compatible = await LocalAuthentication.hasHardwareAsync(); //salvar a referencia de suporte a biometria

    setIsBiometricSupported(compatible);
  };

  //salva o historico da ultima autenticacao
  const SetHistory = async () => {
    const objAuth = {
      dataAuthentication: moment().format("DD/MM/YYYY HH:mm:ss"),
    };

    await AsyncStorage.setItem("authenticate", JSON.stringify(objAuth));

    setDateHistory(objAuth);
  };

  //recebe o historico da ultima autenticacao
  const GetHistory = async () => {
    const objAuth = await AsyncStorage.getItem("authenticate");

    if (objAuth) {
      setDateHistory(JSON.parse(objAuth));
    }
  };

  const HandleAuthentication = async () => {
    //verificar se existe uma biometria cadastrada no dispositivo

    const biometricExist = await LocalAuthentication.isEnrolledAsync();

    //validar se existe ou nao uma biometria cadastrada
    if (!biometricExist) {
      return Alert.alert("Falha ao logar. Nenhuma biometria encontrada!");
    }

    //caso exista:

    const auth = await LocalAuthentication.authenticateAsync();

    setAuthenticated(auth.success);

    if (auth.success) {
      SetHistory();
    }
  };

  useEffect(() => {
    CheckExistAuthentications();
    GetHistory();
    return (cleanUp = () => {});
  }, []);

  return (
    <View style={styles.container}>
      <Text style={styles.title}>
        {isBiometricSupported
          ? "É compatível com a biometria / Face Id!"
          : "Seu dispositivo não tem suporte a biometria / Face Id."}
      </Text>

      <TouchableOpacity onPress={HandleAuthentication} style={styles.btnAuth}>
        <Text style={styles.txtAuth}>Autenticar acesso!</Text>
      </TouchableOpacity>

      <Text
        style={[styles.txtReturn, { color: authenticated ? "green" : "red" }]}
      >
        {authenticated ? "Autenticado!" : "Não autenticado!"}
      </Text>

      {dateHistory.dataAuthentication && (
        <Text style={styles.txtHistory}>
          Último acesso em: {dateHistory.dataAuthentication}
        </Text>
      )}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
  title: {
    fontSize: 20,
    width: "70%",
    textAlign: "center",
    lineHeight: 30,
  },
  btnAuth: {
    padding: 16,
    borderRadius: 10,
    margin: 20,
    backgroundColor: "#ff8800",
  },
  txtAuth: {
    color: "#fff",
    fontWeight: "bold",
    fontSize: 20,
  },
  txtReturn: {
    fontWeight: "bold",
    fontSize: 22,
    marginTop: 50,
  },
  txtHistory: {
    fontSize: 16,
    fontWeight: 'bold',
    color: '#858853'
  },
});

export default App;
