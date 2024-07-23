import React from 'react'

const Field = ({className, type, label, value, id, name, icon}) => {
  return (
    <div>
        <label>{label}</label>
        {value}
        {icon}
    </div>
  )
}

export default Field