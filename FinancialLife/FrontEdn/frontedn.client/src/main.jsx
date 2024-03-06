import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App.jsx';

import {createBrowserRouter, RouterProvider, Route} from 'react-router-dom';

//Paginas
import LoginSignUp from './routes/Login/LoginSignUp.jsx';
import LoginSignIn from './routes/Login/LoginSignIn.jsx';

import './index.css';

const router = createBrowserRouter([
  {
    element: <App/>,
    children: [
      {
        path: "/",
        element: <LoginSignIn/>
      },
      {
        path: "/Cadastro",
        element: <LoginSignUp/>
      }
    ]
  }
])

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>,
)
