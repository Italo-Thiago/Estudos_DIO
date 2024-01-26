import { Card } from '../../components/Card';
import { Header } from '../../components/Header';
import { UserInfo } from '../../components/UserInfo'

import { Container, Column, Title, TitleHighlight } from './styles.js';

const Feed = () => {
    return (<>
        <Header autentication={true} />
        <Container>
            <Column flex={3}>
                <Title>Feed</Title>
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
            </Column>
            <Column flex={1}>
                <TitleHighlight># RANKING 5 TOP DA SEMANA</TitleHighlight>
                <UserInfo percentual={80} nome="Italo Thiago" image="https://avatars.githubusercontent.com/u/115806014?v=4"/>
                <UserInfo percentual={35} nome="Italo Thiago" image="https://avatars.githubusercontent.com/u/115806014?v=4"/>
                <UserInfo percentual={72} nome="Italo Thiago" image="https://avatars.githubusercontent.com/u/115806014?v=4"/>
                <UserInfo percentual={28} nome="Italo Thiago" image="https://avatars.githubusercontent.com/u/115806014?v=4"/>
                <UserInfo percentual={97} nome="Italo Thiago" image="https://avatars.githubusercontent.com/u/115806014?v=4"/>
            </Column>
        </Container>
    </>)
}

export { Feed }