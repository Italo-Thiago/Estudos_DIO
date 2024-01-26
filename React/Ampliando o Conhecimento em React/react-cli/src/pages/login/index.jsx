import { MdLock, MdEmail } from "react-icons/md";

import { useNavigate } from "react-router-dom";

import { Button } from '../../components/Button/';
import { Header } from '../../components/Header/';
import { Input } from '../../components/Input';

import { Column, Container, CreateText, ForgetText, Row, SubtitleLogin, Title, TitleLogin, Wrapper } from './styles.js';

const Login = () => {

    const navigate = useNavigate();

    const handleClickSignIn = () => {
        navigate('/feed');
    }

    return (<>
        <Header />
        <Container>
            <Column>
                <Title>
                    A plataforma para você aprender com experts, dominar as principais tecnologias e entrar mais rápido nas empresas mais desejadas.
                </Title>
            </Column>
            <Column>
                <Wrapper>
                    <TitleLogin>Faça seu cadastro</TitleLogin>
                    <SubtitleLogin>Faça seu login e Make The Change.</SubtitleLogin>
                    <form>
                        <Input placeholder="E-mail" leftIcon={<MdEmail />}/>
                        <Input placeholder="Senha" type="password" leftIcon={<MdLock />}/>
                        <Button title="Entrar" variant='secondary' onClick={handleClickSignIn} type="button"/>
                    </form>
                    <Row>
                        <ForgetText>Esqueci minha senha</ForgetText>
                        <CreateText>Criar Conta</CreateText>
                    </Row>
                </Wrapper>
            </Column>
        </Container>
    </>)
}

export { Login }