import { useState, useCallback} from 'react';

const Teste = () => {
    const [name, setName] = useState('Italo');
    const [age, setAge] = useState(26);

    const handleChangeName = useCallback(() => {
        console.log('alterou nome')
        setName(prev => prev === 'Italo' ? 'Thiago' : 'Italo');
    }, [])

    const handleChangeAge = useCallback(() => {
        const newAge = 10 * age;
        console.log('age atual', age, newAge);
        setAge(prev => prev === 26 ? 32 : 26);
    }, [age])

    return (
        <div>
            <p>
                Idade: {age}
            </p>
            <p>
                Nome: {name}
            </p>
            <br />
            <button onClick={handleChangeName}>Alterar nome</button>
            <br />
            <button onClick={handleChangeAge}>Alterar idade</button>
        </div>
    )
}

export { Teste }