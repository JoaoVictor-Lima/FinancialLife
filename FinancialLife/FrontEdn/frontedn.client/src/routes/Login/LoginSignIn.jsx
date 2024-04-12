import React from 'react'

import './Style/LoginSignIn.css'
import { Link } from 'react-router-dom'

const LoginSignIn = () => {
  return (
    <div className='container'>
      <div className='login-sign-in'>
        <div className='tab-presentation'>
          <div className='presentation'>
            <h3>Bem Vindo Ao Financial Control</h3>
            <p>O app das suas finaças</p>
          </div>
            <div className='image-presentation'>
                <img src="public/Images/imagens-de-financeiro-png-16.png" alt="Imagem" />
            </div>
            <div className='sign-up'>
              {/* mudar para um botão e criar uma formulario */}
              <Link to="/SignUp">Cadastrar</Link>
              <input type="submit" value="Cadastrar"/>
            </div>
        </div>
        <div className='tab-sign-in'>
          <div className='inputs-content'>
            <label htmlFor="email">Dados de login</label>
            <div id='loginFields'>
              <input type="email" id="email" alt="Teste" title="email" placeholder="Email"/>
              <input type="password" id="password" alt="Teste 2" title="Senha" placeholder="Senha"/>
            </div>
          </div>
          <div className='submit-container'> 
              {/* mudar para um botão e criar uma formulario */}
              <input type="submit" value="Esqueci Minha Senha"/>
              <input type="submit" value="Login"/>
          </div>
        </div>
      </div>
    </div>
  )
}

export default LoginSignIn