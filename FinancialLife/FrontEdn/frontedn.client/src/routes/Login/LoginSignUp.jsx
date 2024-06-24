import React, { useState } from 'react';
import SignUpForm from '../../Core/Componets/Forms/SignUpForm/SignUpForm'
import './Style/LoginSignUp.css'



const ConfigResposta = (data) => {
  //setResponseData(data)
}

const LoginSignUp = () => {

  const items = {
    url: 'PessoaFisica/Create',
    className: 'default-form',
    onSuccess: ConfigResposta(),
    fields:  [
      {
        name: 'Nome', 
        Id: 'Nome',
        label: 'Nome', 
        type: 'text'
      },
      {
        name: 'DataNascimento',
        Id: 'DataNascimento', 
        label: 'Data de Nascimento', 
        type: 'Date'
      },
      {
        name: 'Cpf', 
        Id: 'Cpf', 
        label: 'Cpf', 
        type: 'text'
      },
      {
        name: 'IdGeneroPessoa', 
        Id: 'IdGeneroPessoa', 
        label: 'Genero Pessoa', 
        type: 'number'
      },
      {
        name: 'TelefonePessoa',
        fields: [
          {
            name: 'Ddd', 
            Id: 'DddTelefonePessoa', 
            label: 'DDD', 
            type: 'string'
          },
          {
            name: 'Numero', 
            Id: 'NumeroTelefonePessoa', 
            label: 'Numero', 
            type: 'string'
          },
        ]
      },
      {
        name: 'EmailPessoa',
        fields: [
          {
            name: 'Email', 
            Id: 'Email', 
            label: 'E-mail Login', 
            type: 'text'
          },
        ]
      },
      {
        name: 'EnderecoPessoa',
        fields: [
          {
            name: 'Logradouro',
            Id: 'RuaEnderecoPessoa',  
            label: 'Rua', 
            type: 'Text'
          },
          {
            name: 'Numero', 
            Id: 'NumeroEnderecoPessoa',  
            label: 'Numero', 
            type: 'number'
          },
          {
            name: 'Complemento', 
            Id: 'ComplementoEnderecoPessoa',  
            label: 'Complemento', 
            type: 'text'
          },
          {
            name: 'Bairro', 
            Id: 'BairroEnderecoPessoa',  
            label: 'Bairro', 
            type: 'text'
          },
          {
            name: 'IdCidade', 
            Id: 'CidadeEnderecoPessoa',  
            label: 'Cidade', 
            type: 'number'
          },
          {
            name: 'IdEstado', 
            Id: 'EstadoEnderecoPessoa',  
            label: 'Estado', 
            type: 'number'
          },
          {
            name: 'IdPais', 
            Id: 'PaisEnderecoPessoa',  
            label: 'Pais', 
            type: 'number'
          },
        ]
      },
    ],
  }

  return (
    <SignUpForm {...items} />
  )
}

export default LoginSignUp