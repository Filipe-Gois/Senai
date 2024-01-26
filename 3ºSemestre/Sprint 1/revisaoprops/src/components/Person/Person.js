import { View, Text, StyleSheet } from "react-native";

const Person = ({ name, age }) => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>Nome: {name}</Text>
            <Text style={styles.text}>Idade: {age}</Text>
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
        color: 'red'
    },
})

export default Person;