import React from 'react'

import './NavBar.css'

const NavBar = ({ onSelect, className, children }) => {
  return (
    <nav className={className ?? 'nav-bar'}>
       {children}
    </nav>
  )
}

export default NavBar