import React from 'react'

const LoginSignIn = () => {
  return (
    <div className='login-Sign-In'>
      <div className='tab-Presentation'>
          <h3>Bem Vindo Ao Financial Control</h3>
          <p>O app das suas finaças</p>
          <div className='image-Presentation'>
              Imagem
          </div>
      </div>
      <div className='tab-Sign-In'>
        <div className='inputs-content'>
            <input type="email" alt="Teste"/>
            <input type="password" alt="Teste 2"/>
        </div>
        <div className='submit-container'> 
            <input type="submit" value="Esqueci Minha Senha"/>
            <input type="submit" value="Login"/>
            <input type="submit" value="Cadastrar"/>
        </div>
      </div>
    </div>
  )
}

export default LoginSignIn