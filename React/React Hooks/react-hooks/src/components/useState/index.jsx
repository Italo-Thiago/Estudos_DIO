import { useState, useMemo } from 'react';

const Teste = () => {
    const [age, setAge] = useState(26);

    const handleChangeName = () => {
        setAge(prev => prev === 26 ? 32 : 26);
    }

    const calculo = useMemo(() => {
        console.log('calculo', age)
        return 10 * age; 
    }, []);

    console.log('renderizou', calculo)

    return (
        <div>
            <p>
                {age}
            </p>
            <button onClick={handleChangeName}>Alterar</button>
        </div>
    )
}

export { Teste }