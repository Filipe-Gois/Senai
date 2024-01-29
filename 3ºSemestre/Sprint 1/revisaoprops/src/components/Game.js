import { Text, View, StyleSheet } from "react-native";



const Game = ({ name, desenvolvedora, dataLancamento }) => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>{name}</Text>
            <Text style={styles.text}>{desenvolvedora}</Text>
            <Text style={styles.text}>{dataLancamento}</Text>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        backgroundColor: '#c1c1c1',
        padding: 15,
        margin: 15,
        borderRadius: 20,
    },
    text: {
        color: 'red',
        // fontFamily: 'Poppins_300Light'
        fontFamily: 'SingleDay_400Regular'

    },
})

export default Game;