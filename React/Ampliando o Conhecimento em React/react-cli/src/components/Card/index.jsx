import React from 'react';
import { FiThumbsUp } from 'react-icons/fi'

import {
    CardContainer,
    Content,
    HasInfo,
    ImageBackground,
    PostInfo,
    UserInfo,
    UserPictures,

} from './styles';

const Card = () => {
    return (
        <CardContainer>
            <ImageBackground src='https://hermes.dio.me/articles/cover/364fb700-4c6f-482b-91fe-6c66b31ae8a1.jpg'/>
            <Content>
                <UserInfo>
                    <UserPictures src='https://avatars.githubusercontent.com/u/115806014?v=4'/>
                    <div>
                        <h4>Italo Thiago</h4>
                        <p>Há 6 minutos</p>
                    </div>
                </UserInfo>
                <PostInfo>
                    <h4>Projeto para curso de HTML e CSS</h4>
                    <p>Projeto feito o curso de HTML e CSS no Bootcamp da dio do Global avanade...<strong>Saiba Mais</strong></p>
                </PostInfo>
                <HasInfo>
                    <h4>#HTML #CSS #JavaScript</h4>
                    <p>
                        <FiThumbsUp /> 10
                    </p>
                </HasInfo>
            </Content>
        </CardContainer>
    )
}

export { Card }