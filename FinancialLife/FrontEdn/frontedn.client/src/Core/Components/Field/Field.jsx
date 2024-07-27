import React, { useState, forwardRef, useImperativeHandle } from 'react'

import './Field.css'

const Field = forwardRef(({className, type, label, value, id, name, icon, readOnly, onChange, onBlur, onFocus}, ref) => {

  const [fieldValue, setFieldValue] = useState(value);

  const handleChange = () => {
    const newValue = e.target.value;
    setFieldValue(newValue);
    if (onChange) {
      onChange(e);
    }
  }

  const handleFocus = () => {

  }

  useImperativeHandle(ref, () => ({
    getName: () => name,
    setValue: (newValue) => setFieldValue(newValue)
  }));


  return (
    <div 
      className={className ?? 'default-field'} 
      data-type="field">
      <label htmlFor={id}>{label}</label>
      <div className='default-field-input'>
        <input 
          type={type} 
          id={id}
          name={name}
          value={fieldValue}
          onChange={handleChange}
          onBlur={onBlur}
          onFocus={handleFocus}
        />
      </div>
      {icon && <span className="default-field-icon">{icon}</span>}
    </div>
  )
});

export default Field