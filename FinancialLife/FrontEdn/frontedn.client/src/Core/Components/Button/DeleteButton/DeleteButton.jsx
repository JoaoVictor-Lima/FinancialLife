import React from 'react'
import DefaultButton from '../DefaultButton/DefaultButton.Jsx'
import api from '../../../Utils/Api/axios'

const DeleteButton = (url, data, className) => {
    const handlerClick = async () => {
        try{
            const response = await api.delete(url, data);
        }
        catch (error){
            //Criar mensagem na tela retornando o erro e a mensagem do erro para que seja enviada ao desenvolvedor
        }
    }
  return (
    <DefaultButton
    onClick={handlerClick}
    className={className}>

    </DefaultButton>
  )
}

export default DeleteButton