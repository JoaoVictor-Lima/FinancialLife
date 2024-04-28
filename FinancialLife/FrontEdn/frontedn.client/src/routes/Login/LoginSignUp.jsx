import React from 'react'
import SignUpForm from '../../Core/Componets/Forms/SignUpForm/SignUpForm'

const LoginSignUp = () => {

  const items = {
    url: 'Api/v1/PessoaFisica/GetAll',
    fields:  [
      {name: 'username', label: 'Username', type: 'text'},
      {name: 'Password', label: 'Password', type: 'password'},
      {name: 'Nome', label: 'Nome', type: 'text'},
      {name: 'LeriGo', label: 'LeriGo', type: 'text'},
    ],
  }

  return (
    <SignUpForm {...items} />
  )
}

export default LoginSignUp