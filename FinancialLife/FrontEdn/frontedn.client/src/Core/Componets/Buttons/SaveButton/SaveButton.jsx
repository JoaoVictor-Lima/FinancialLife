import React from 'react'
import DefaultButton from '../DefaultButton/DefaultButton.jsx'
import api from '../../../Utils/Api/axios'
import { HttpMethodEnum } from '../../../Utils/Enums/HttpMethodEnum.js'

const handleClick = async (url, data, method) => {
    try{
      let response;
      if (method === HttpMethodEnum.POST) 
      {
        response = await api.post(url, data);
      } 
      else if (method === HttpMethodEnum.PUT) 
      {
          response = await api.put(url, data);
      } 
      else 
      {
        throw new Error('Método HTTP inválido');
      }
    }
    catch (error){
      console.log(error)
        //Criar mensagem na tela retornando o erro e a mensagem do erro para que seja enviada ao desenvolvedor
    }
}

const SaveButton = ({url, data, method, className}) => {

  return (
    <DefaultButton
    onClick={() => handleClick(url, data, method)}
    className={className}>
        Salvar
    </DefaultButton>
  )
}

export default SaveButton