import React from 'react'

import './Panel.css' 

const Panel = ({children, className, style, onClick }) => {
  return (
    <div className = {className ?? 'default-panel'}
      style={style}
      onClick={onClick}>
      {children}
    </div>
  )
}

export default Panel