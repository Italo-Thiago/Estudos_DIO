import { useState, useEffect } from 'react';

const Teste = () => {
    const [name, setName] = useState('Italo');

    const handleChangeName = () => {
        setName(prev => prev === 'Italo' ? 'Thiago' : 'Italo')
    }

    useEffect(() => {
        alert('renderizei')
    }, [name]);

    return (
        <div>
            <p>
                {name}
            </p>
            <button onClick={handleChangeName}>Alterar</button>
        </div>
    )
}

export { Teste };