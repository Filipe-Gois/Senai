import { StatusBar } from "expo-status-bar";
import { StyleSheet, Text, TouchableOpacity, View } from "react-native";

import AveMaria from "./assets/AveMaria.mp3";

//importar recursos do expo notification

import * as Notifications from "expo-notifications";

//solicita permissões de notificação ao iniciar o APP
Notifications.requestPermissionsAsync();

//define como as notificações devem ser tratadas quando recebidas
Notifications.setNotificationHandler({
  handleNotification: async () => ({
    //mostra um alerta quando a notificação for recebida
    shouldShowAlert: true,

    //reproduz som ao receber notificação
    shouldPlaySound: true, //desativa som da notificação

    //numero de notificações no icone do app
    shouldSetBadge: false,
  }),
});

const App = () => {
  //função para lidar com a chamada da notificação
  const HandleCallNotifications = async () => {
    //obtém o status da permissão
    const { status } = await Notifications.requestPermissionsAsync();

    if (status !== "granted") {
      alert("Você não ativou as notificações!");
      return;
    }

    //agenda uma notificação
    await Notifications.scheduleNotificationAsync({
      content: {
        title: "Bem-vindo ao Senai!",
        body: "Notificação recebida!",
        sound: AveMaria,
      },
      trigger: null,
    });
  };

  return (
    <View style={styles.container}>
      <TouchableOpacity onPress={HandleCallNotifications} style={styles.btn}>
        <Text style={styles.text}>Clique aqui!</Text>
      </TouchableOpacity>
      <StatusBar style="auto" />
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
  btn: {
    width: "40%",
    height: 90,
    backgroundColor: "red",
    alignItems: "center",
    justifyContent: "center",
    borderRadius: 15,
  },
  text: {
    color: "#fff",
    fontSize: 24,
  },
});

export default App;
