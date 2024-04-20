import React, { useState } from 'react';
import SaveButton from '../../Buttons/SaveButton/SaveButton'


const handleChange = (event, setFormData, formData) => {
  const { name, value } = event.target;
  setFormData({ ...formData, [name]: value });
};

const handleSubmit = (event) => {
  event.preventDefault();
};

const DefaultForm = ({fields, url, method, className}) => {
  const [formData, setFormData] = useState({});

  const handleFormChange = (event) => handleChange(event, setFormData, formData);
  const handleFormSubmit = (event) => handleSubmit(event);

  return (
    <form onSubmit={handleFormSubmit}>
        {fields.map((field, index) => (
          <div key={index}>
              <label htmlFor={field.name}>{field.label}</label>
              <input 
                type={field.type}
                id={field.name}
                name={field.name}
                value={formData[field.name] || '' }
                onChange={handleFormChange}/>
          </div>
        ))}
        <SaveButton url={url} data={formData} method={method} />
    </form>
  )
}

export default DefaultForm