import React from 'react'
import DefaultForm from '../../Core/Componets/Forms/DefaultForm/DefaultForm'

const LoginSignUp = () => {
  const campos = [
    {name: 'username', label: 'Username', type: 'text'},
  ]
  return (
    <DefaultForm campos={campos}>

    </DefaultForm>
  )
}

export default LoginSignUp