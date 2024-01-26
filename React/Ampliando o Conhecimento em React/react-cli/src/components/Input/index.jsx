import React from 'react';

import { IconContainer, InputText, InputContainer } from './styles';

const Input = ({ leftIcon, name, ...rest }) => {
    return (
        <IconContainer>
            {leftIcon ? (<InputContainer>{leftIcon}</InputContainer>) : null}
            <InputText {...rest}/>
        </IconContainer>
    )
}

export { Input };