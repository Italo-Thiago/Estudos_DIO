import { useState } from 'react';
import { Header } from "../../components/Header";
import background from "../../assets/background.png";
import ItemList from "../../components/ItemList";

import './styles.css';

function App() {
  const [user, setUser] = useState('');
  const [currentUser, setCurrentUser] = useState(null);
  const [repos, setRepos] = useState(null);
  
  const handleGetData = async () => {
    const userData = await fetch(`https://api.github.com/users/${user}`);
    const newUser = await userData.json();

    if (newUser.name) {
      const { avatar_url, name, bio, login} = newUser;
      setCurrentUser({ avatar_url, name, bio , login});

      const reposData = await fetch(`https://api.github.com/users/${user}/repos`);
      const newRepos = await reposData.json();

      if (newRepos.length) {
        setRepos(newRepos);
      }
    }

  }

  return (
    <div className="App">
      <Header />
      <div className="context">
        <img src={background} className="background" alt="background app" />
        <div className="info">
          <div>
            <input
              nome="User"
              value={user}
              onChange={event => setUser(event.target.value)}
              placeholder="@username" />
            <button onClick={handleGetData}>Search</button>
          </div>
          {currentUser?.name ? (
            <>
            <div className="profile">
              <img
                // TODO mudar a foto de perfil dinamicamente
                src={currentUser.avatar_url}
                className="image_profile"
                alt="Profile"
                />
                <div>
                  {/* TODO Colocar o nome e a descrição dinamicamente através da API do GitHub */}
                  <h3>{currentUser.name}</h3>
                  <span>@{currentUser.login}</span>
                  <p>{currentUser.bio}</p>
                  <button className='profileButton'>Link</button>
                </div>
              </div>
              <hr />
            </>
          ) : null}
          {repos?.length ? (
            <div>
              <h4 className="repositorio">Repositórios</h4>
              {repos.map(repo => (
                <ItemList title={repo.name} description={repo.description} />
              ))}
            </div>  
          ) : null}
        </div>
      </div>
    </div>
  );
}

export default App;
