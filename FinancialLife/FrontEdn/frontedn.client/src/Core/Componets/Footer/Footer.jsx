import React from 'react'

import './Footer.css'

const Footer = ({className, children}) => {
  return (
    <div className={className ?? 'default-footer'}>
      {children}
    </div>
  )
}

export default Footer