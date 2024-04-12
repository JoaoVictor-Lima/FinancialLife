import React from 'react'
import DefaultButton from '../DefaultButton/DefaultButton.jsx'
import api from '../../../Utils/Api/axios'

const handleClick = async () => {
    try{
        const response = await api.post(url, data);
    }
    catch (error){
        //Criar mensagem na tela retornando o erro e a mensagem do erro para que seja enviada ao desenvolvedor
    }
}

const SaveButton = ({url, data, className}) => {

  return (
    <DefaultButton
    onClick={() => handleClick(url, data)}
    className={className}>
        Salvar
    </DefaultButton>
  )
}

export default SaveButton