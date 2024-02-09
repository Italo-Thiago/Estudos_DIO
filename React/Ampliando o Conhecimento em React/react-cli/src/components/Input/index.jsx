import React from 'react';

import { IconContainer, InputText, InputContainer } from './styles';
import { Controller } from "react-hook-form";
    
const Input = ({ leftIcon, name, control ,...rest }) => {
    return (
        <IconContainer>
            {leftIcon ? (<InputContainer>{leftIcon}</InputContainer>) : null}
            <Controller
                name={name}
                control={control}
                rules={{ required: true }}
                render={({field}) => <InputText {...field} {...rest} />}
            />
        </IconContainer>
    )
}

export { Input };