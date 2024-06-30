import React from 'react'

import './NavBar.css'

const NavBar = ({ onSelect, className }) => {
  return (
    <div className={className ?? 'NavBar'}>
       <ul>
        <li onClick={() => onSelect('Dashboard')}>Dashboard</li>
        <li onClick={() => onSelect('Expenses')}>Expenses</li>
        <li onClick={() => onSelect('Income')}>Income</li>
        <li onClick={() => onSelect('Goals')}>Goals</li>
      </ul>
    </div>
  )
}

export default NavBar