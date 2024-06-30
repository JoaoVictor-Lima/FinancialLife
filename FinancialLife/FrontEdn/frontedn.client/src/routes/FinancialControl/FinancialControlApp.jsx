import React, { useState } from 'react';

import './FinancialControlApp.css'

import Panel from '../../Core/Componets/Panel/BasePanel/Panel';
import NavBar from '../../Core/Componets/Navbar/NavBar';
import Footer from '../../Core/Componets/Footer/Footer';



const FinancialControlApp = () => {

  // const [selectedContent, setSelectedContent] = useState('Dashboard')
  
  return (
    <Panel className='default-panel financial-control-panel'>
        <NavBar className='financial-control-nav-bar'>
          NavBar
          </NavBar>
          <Panel className='content-panel'>
            Panel
          </Panel>
          <Footer className='financial-control-footer'>
            footer
          </Footer>
          
    </Panel>
  )
}

export default FinancialControlApp