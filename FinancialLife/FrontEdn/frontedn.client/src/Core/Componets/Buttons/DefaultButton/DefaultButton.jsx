import React from 'react'
import './DefaultButton.css'

const DefaultButton = ({onClick, children, className}) => {
  return (
    <button 
    onClick={onClick}
    className={`default-button ${className}`}>
        {children}
    </button>
  )
}

export default DefaultButton