import { Button } from '../../components/Button';
import { Header } from '../../components/Header';

import bannerImage from '../../assets/banner.png'

import { Container, TitleContext, Title, TitleHighlight } from './styles.js';

const Home = () => {
    return (<>
        <Header />
        <Container>
            <div>
                <Title>
                    <TitleHighlight>
                    Implemente
                    <br />
                    </TitleHighlight> 
                    o seu futuro global agora!
                </Title>
                <TitleContext>
                    Domine asa tecnologias utilizadas pelas empresas mais inovadoras do mundo e encare seu novo desafio profissional, evoluindo em comunidade com os melhores experts.
                </TitleContext>
                <Button title="Começar agora" variant="secundary" onClick={ () => null } />
            </div>
            <div>
                <img src={bannerImage} alt='Imagem principal' />
            </div>
        </Container>
    </>)
}

export { Home }