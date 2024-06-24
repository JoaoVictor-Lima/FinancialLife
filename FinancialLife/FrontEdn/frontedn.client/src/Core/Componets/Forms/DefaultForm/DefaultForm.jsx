import React, { useState } from 'react';
import SaveButton from '../../Buttons/SaveButton/SaveButton';
import formatValueByType from '../../../Utils/DataFormatting/FomartValueByType';

import './DefaultForm.css'

function setValueByPath(obj, path, value) {
  const keys = path.split('.');
  const lastKey = keys.pop();
  const lastObj = keys.reduce((obj, key) => obj[key] = obj[key] || {}, obj);
  lastObj[lastKey] = value;
}

function getValueByPath(obj, path) {
  return path.split('.').reduce((acc, part) => acc && acc[part], obj) || '';
}

function handleChange(event, setFormData) {
  const { name, value, type } = event.target;
  const formattedValue = formatValueByType(type, value); 
  setFormData(prev => {
    const newData = { ...prev };
    setValueByPath(newData, name, formattedValue);
    return newData;
  });
}

const renderFields = (fields, formData, handleFormChange, path = '') => {
  return fields.map((field, index) => {
    const currentPath = path ? `${path}.${field.name}` : field.name; 
    if (field.fields) {
      return (
        <fieldset 
          key={index}
          className={field.className ?? 'default-fieldset'}>
          <legend>{field.label}</legend>
          {renderFields(field.fields, formData, handleFormChange, currentPath)}
        </fieldset>
      );
    } else {
      return (
        <div 
          key={index}
          className={field.className ?? `default-field`}>
          <label htmlFor={field.Id}>{field.label}</label>
          <input
            type={field.type}
            id={field.Id}
            name={currentPath}
            value={getValueByPath(formData, currentPath)}
            onChange={handleFormChange}
          />
        </div>
      );
    }
  });
};

const handleSubmit = (event) => {
  event.preventDefault();
};

const DefaultForm = ({fields, url, model, method, className, onSuccess}) => {
  const [formData, setFormData] = useState({});
  const [reponseData, setResposeData] = useState({});

  const handleFormChange = (event) => handleChange(event, setFormData);
  const handleFormSubmit = (event) => handleSubmit(event);

  return (
    <form onSubmit={handleFormSubmit} className={className ?? 'default-form'} >
      <div className='fields'>
        {renderFields(fields, formData, handleFormChange)}
      </div>
        <div className='buttons'>
          <SaveButton 
          url={url} 
          data={formData} 
          method={method} 
          model={model} 
          onSuccess={setResposeData} />
        </div>
    </form>
  )
}

export default DefaultForm