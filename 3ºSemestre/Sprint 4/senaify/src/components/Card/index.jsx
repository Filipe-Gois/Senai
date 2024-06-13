import { useEffect, useState } from "react";
import {
  CheckMusic,
  LikeMusic,
  DeslikeMusic,
} from "../../utils/LikeAndDeslike";

// Importando as ferramentas
import { MaterialIcons, FontAwesome } from "@expo/vector-icons";

// Importando os estilos
import { CardAlbum, CardMusic } from "./styles";

// Importando os components
import { ButtonLike } from "../Button/styles";
import { ImageAlbum, ImageMusic } from "../Image/styles";
import { Paragraph, SubParagraph } from "../Text/Paragraph/styles";
import { ContainerMusic, ContainerSound } from "../Container/styles";

export const Album = ({
  image,
  name,
  description,
  onPress,
  label = "",
  labelName = "",
}) => {
  return (
    <CardAlbum onPress={onPress} accessibilityLabel={label}>
      <ImageAlbum source={{ uri: image }} />

      <Paragraph accessibilityLabel={labelName}>{name}</Paragraph>

      <SubParagraph>{description}</SubParagraph>
    </CardAlbum>
  );
};

export const Music = ({
  image,
  name,
  artist,
  play = false,
  isLike = false,
  like,
  onPress,
  label,
  labelName = "",
  labelButton
}) => {
  const [isLiked, setIsLiked] = useState(isLike);

  // Função para curtir e descurtir a música
  async function handleLike() {
    if (isLiked) {
      await DeslikeMusic(like);
      setIsLiked(false);
    } else {
      await LikeMusic(like);
      setIsLiked(true);
    }
  }

  return (
    <CardMusic accessibilityLabel={label} onPress={onPress}>
      <ContainerSound>
        <ImageMusic playSound={play} source={{ uri: image }} />

        {play && (
          <MaterialIcons
            name="pause"
            size={24}
            color="#fbfbfb"
            style={{ position: "absolute" }}
          />
        )}
      </ContainerSound>

      <ContainerMusic>
        <Paragraph accessibilityLabel={labelName}> {name}</Paragraph>

        <SubParagraph>{artist}</SubParagraph>
      </ContainerMusic>

      {like && (
        <ButtonLike onPress={() => handleLike()} testID={labelButton}>
          {isLiked ? (
            <FontAwesome
              name="heart"
              size={18}
              color="#FF0000"
              accessibilityLabel="icon-like"
            />
          ) : (
            <FontAwesome
              name="heart-o"
              size={18}
              color="#1ED760"
              accessibilityLabel="icon-deslike"
            />
          )}
        </ButtonLike>
      )}
    </CardMusic>
  );
};
