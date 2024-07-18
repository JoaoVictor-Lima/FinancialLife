import React, { useState } from 'react';
import { MdHome, MdOutlineWallet, MdAccountCircle  } from 'react-icons/md';

//style
import './FinancialControl.css';

//Components
import Panel from '../../Core/Containers/Base/Panel/Panel';
import NavBar from '../../Core/Containers/Navbar/NavBar';
import Footer from '../../Core/Containers/Footer/Footer';

//Aplications
import Home from './Home/Home';
import Profile from './Profile/Profile';
import Wallet from './Wallet/Wallet';

const FinancialControl = () => {

  const [selectedNavItem, setSelectedNavItem] = useState('Home')

  const content = (selectedNavItem) => {
    switch (selectedNavItem) {
      case 'profile': 
      return <Profile/>
      case 'Home': 
      return <Home/>
      case 'wallet': 
      return <Wallet/>
    }
  }

  return (
    <Panel className='default-panel home-panel'>
        <NavBar className='home-nav-bar'>
            <MdAccountCircle 
              size={40} 
              className={`nav-item nav-item-profile ${selectedNavItem === 'profile' ? 'active' : ''}`}
              onClick={() => setSelectedNavItem('profile')}/>
            <MdHome 
              size={30} 
              className={`nav-item ${selectedNavItem === 'Home' ? 'active' : ''}`}
              onClick={() => setSelectedNavItem('Home')}/>
            <MdOutlineWallet 
              size={30} 
              className={`nav-item ${selectedNavItem === 'wallet' ? 'active' : ''}`}
              onClick={() => setSelectedNavItem('wallet')}/>
          </NavBar>
          <Panel className='content-panel'>
            {content(selectedNavItem)}
          </Panel>
          <Footer className='home-footer'>

          </Footer>
    </Panel>
  )
}

export default FinancialControl