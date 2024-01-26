import React from 'react';
import { Button } from '../Button';

import logo from '../../assets/logo-dio.png';

import {
    SearchInputContainer,
    Container,
    Input,
    Menu,
    MenuRight,
    Row,
    Wrapper,
    UserPicture
}
from './styles';

const Header = ({autentication}) => {
    return (
        <Wrapper>
            <Container>
                <Row>
                    <img src={logo} alt='Logo da DIO' />    
                    {autentication ? (
                        <>
                            <SearchInputContainer>
                                <Input placeholder='Buscar...'/>
                            </SearchInputContainer>
                            <Menu>Live Code</Menu>
                            <Menu>Global</Menu>
                        </>
                    ) : null}
                </Row>
                <Row>
                    {autentication ? (
                        <UserPicture src="https://avatars.githubusercontent.com/u/115806014?v=4"/>
                    ) : (
                        <>
                            <MenuRight href='#'>Home</MenuRight>
                            <Button title="Entrar" />
                            <Button title="Cadastrar" />
                        </>
                    )} 
                </Row>
            </Container>
        </Wrapper>
    )
}

export { Header };