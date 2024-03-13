import { StatusBar } from "expo-status-bar";
import {
  Image,
  Modal,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from "react-native";
import { Camera, requestCameraPermissionsAsync, CameraType } from "expo-camera";
import { useEffect, useRef, useState } from "react";
import { FontAwesome } from "@expo/vector-icons";

const App = () => {
  const cameraRef = useRef();
  const [openModal, setOpenModal] = useState(false);
  const [photo, setPhoto] = useState();
  const [tipoCamera, setTipoCamera] = useState(CameraType.front);

  const CapturePhoto = async () => {
    if (cameraRef) {
      const photo = await cameraRef.current.takePictureAsync();

      setPhoto(photo.uri);
      setOpenModal(true);

      console.log(photo);
    }
  };

  useEffect(() => {
    (async () => {
      const { status: cameraStatus } = await requestCameraPermissionsAsync();
    })();

    return (cleanUp = () => {});
  }, []);
  return (
    <View style={styles.container}>
      <Camera
        ref={cameraRef}
        style={styles.camera}
        ratio="16:9"
        type={tipoCamera}
      >
        <View style={styles.viewFlip}>
          <TouchableOpacity
            onPress={() =>
              setTipoCamera(
                tipoCamera === CameraType.back
                  ? CameraType.front
                  : CameraType.back
              )
            }
            style={styles.btnFlip}
          >
            <Text style={styles.txtFlip}>Trocar</Text>
          </TouchableOpacity>
        </View>
      </Camera>

      <TouchableOpacity
        onPress={() => CapturePhoto()}
        style={styles.btnCapture}
      >
        <FontAwesome name="camera" size={23} color="#fff" />
      </TouchableOpacity>

      <Modal animationType="slide" transparent={false} visible={openModal}>
        <View
          style={{
            flex: 1,
            justifyContent: "center",
            alignItems: "center",
            margin: 20,
          }}
        >
          <View style={{ margin: 10, flexDirection: "row" }}>
            {/* botoes de controle */}
            <FontAwesome
              onPress={() => setOpenModal(!openModal)}
              name="camera"
              size={23}
              color="#000"
            />
          </View>

          <Image
            style={{ width: "100%", height: 500, borderRadius: 20 }}
            source={{ uri: photo }}
          />
        </View>
      </Modal>
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
  camera: {
    flex: 1,
    height: "100%",
    width: "100%",
  },
  viewFlip: {
    flex: 1,
    backgroundColor: "transparent",
    flexDirection: "row",
    alignItems: "flex-end",
    justifyContent: "center",
  },
  btnFlip: {
    padding: 20,
  },
  txtFlip: {
    fontSize: 20,
    color: "#fff",
    marginBottom: 20,
  },
  btnCapture: {
    padding: 20,
    margin: 20,
    borderRadius: 10,
    backgroundColor: "#121212",
    justifyContent: "center",
    alignItems: "center",
  },
});

export default App;
