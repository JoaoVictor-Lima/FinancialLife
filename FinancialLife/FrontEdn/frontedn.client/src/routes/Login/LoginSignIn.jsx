import { React, useState} from 'react'
import DefaultButton from '../../Core/Componets/Buttons/DefaultButton/DefaultButton'

import './Style/LoginSignIn.css'
import { Link } from 'react-router-dom'
import api from '../../Core/Utils/Api/axios'

const LoginSignIn = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleEmailChange = (event) => {
    setEmail(event.target.value);
  };

  const handlePasswordChange = (event) => {
    setPassword(event.target.value);
  };

  const confirmLogin = async () => {
    debugger
    const data = {email, password}
    const response = await api.post('teste', data)
  };

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
              <DefaultButton> 
                <Link to="/SignUp">Cadastrar</Link>
              </DefaultButton> 
            </div>
        </div>
        <div className='tab-sign-in'>
          <div className='inputs-content'>
            <label htmlFor="email">Dados de login</label>
            <div id='loginFields'>
              <input  type="email" 
                      alt="Teste" 
                      id="email" 
                      title="email" 
                      placeholder="Email"
                      value={email}
                      onChange={handleEmailChange}
                      />
              <input  type="password" 
                      id="password" 
                      alt="Teste 2" 
                      title="Senha" 
                      placeholder="Senha"
                      value={password}
                      onChange={handlePasswordChange}
                      />
            </div>
          </div>
          <div className='submit-container'> 
              {/* mudar para um botão e criar uma formulario */}
              <input type="submit" value="Esqueci Minha Senha"/>
              <DefaultButton 
                onClick={confirmLogin}
                children={<div>Login</div>}
             /> 
          </div>
        </div>
      </div>
    </div>
  )
}

export default LoginSignIn