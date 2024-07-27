import React, { forwardRef } from 'react';

import './Panel.css'

const Panel = forwardRef(({children, className, style, onClick }, ref) => {
  return (
    <div 
      className = {className ?? 'default-panel'}
      ref={ref}
      style={style}
      onClick={onClick}>
      {children}
  </div>
  )
});

export default Panel