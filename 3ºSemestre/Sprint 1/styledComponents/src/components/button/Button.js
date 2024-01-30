import styled from "styled-components";
import { Theme } from "../../Theme";

export const ButtonIncrement = styled.TouchableOpacity`
    background-Color: ${Theme.colors.blue};
    width: 100px;
    height: 40px;
    display: flex;
    align-Items: center;
    justify-Content: center;
    border-Radius: 50px;
    margin: 20px;
`

export const ButtonDecrement = styled(ButtonIncrement)`
background-color: ${Theme.colors.red};
`