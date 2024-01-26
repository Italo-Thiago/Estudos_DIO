import { useNavigate } from 'react-router-dom';

import bannerImage from '../../assets/banner.png'
import { Button } from '../../components/Button';
import { Header } from '../../components/Header';

import { Container, TitleContext, Title, TitleHighlight } from './styles.js';

const Home = () => {

    const navigate = useNavigate();

    const handleClickSignIn = () => {
        navigate('/login');
    }
    
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
                <Button title="Começar agora" variant="secundary" onClick={handleClickSignIn} />
            </div>
            <div>
                <img src={bannerImage} alt='Imagem principal' />
            </div>
        </Container>
    </>)
}

export { Home }