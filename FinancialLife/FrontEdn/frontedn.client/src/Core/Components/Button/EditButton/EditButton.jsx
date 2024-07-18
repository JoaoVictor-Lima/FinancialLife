import React from 'react'
import api from '../../../Utils/Api/axios'
import DefaultButton from '../DefaultButton/DefaultButton.Jsx';

const EditButton = (url, data, className) => {

    const handlerClick = async () => {
        try{
            const response = api.put(url, data);
        }
        catch{
            //Criar mensagem na tela retornando o erro e a mensagem do erro para que seja enviada ao desenvolvedor
        }
    }

  return (
    <DefaultButton
    onClick={handlerClick}
    className={className}>
        Editar
    </DefaultButton>
  )
}

export default EditButton