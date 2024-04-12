import React, { useState } from 'react';
import SaveButton from '../../Buttons/SaveButton/SaveButton'

const handleChange = (event, setFormData, formData) => {
  const { name, value } = event.target;
  setFormData({ ...formData, [name]: value });
};

const handleSubmit = (event, onSubmit, formData) => {
  event.preventDefault();
  onSubmit(formData);
};

const DefaultForm = ({campos, onSubmit, onCancel, children}) => {
  const [formData, setFormData] = useState({});

  const handleFormChange = (event) => handleChange(event, setFormData, formData);
  const handleFormSubmit = (event) => handleSubmit(event, onSubmit, formData);

  return (
    <form onSubmit={handleFormSubmit}>
        {campos.map((campo, index) => (
          <div key={index}>
              <label htmlFor={campo.name}>{campo.label}</label>
              <input 
                type={campo.type}
                id={campo.name}
                name={campo.name}
                value={formData[campo.name] || '' }
                onChange={handleFormChange}/>
          </div>
        ))}
        <SaveButton onClick={handleSubmit}/>
    </form>
  )
}

export default DefaultForm