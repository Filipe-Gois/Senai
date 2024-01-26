import { View, Text, StyleSheet } from "react-native";

import { StatusBar } from 'expo-status-bar';
import useLoadFonts from '../useLoadFonts/useLoadFonts';
import * as SplashScreen from 'expo-splash-screen';
SplashScreen.preventAutoHideAsync();


const Label = ({ id, text }) => {

    const { fontsLoaded, onLayoutRootView } = useLoadFonts();

    if (!fontsLoaded)
        return null;
    return (
        <View onLayout={onLayoutRootView} style={styles.label}>
            <Text id={id} style={styles.labelText}>{text}</Text>
        </View>
    );
};

const styles = StyleSheet.create({
    label: {
        width: '100%',
        height: 10,
        padding: 20,
        alignSelf: 'center'
    },
    labelText: {
        color: '#002240',
        fontFamily: 'Poppins_Regular'
    }

});

export default Label;