import React, { useState, useEffect } from 'react'
import getEnum from '../../Utils/Api/getEnum';
import api from '../../Utils/Api/axios';
import './Select.css'

const Select = ({options, value, onChange, placeholder, className, url, loadOnFocus }) => {

  //States
  const [optionsSelect, setOptionsSelect] = useState([]);
  const [selectedValue, setSelectedValue] = useState('');
  const [selectPlaceholder, setselectPlaceholder] = useState(null);

  //Effect
  useEffect(() => {
    if(!loadOnFocus)
      getSelectOptions(url, options);

    if (value !== undefined && value !== '') {
      setSelectedValue(value);
    }

    setselectPlaceholder(placeholder);
  },[url, options, loadOnFocus, value, placeholder]);

  //Logic
  const getSelectOptions = async (url, options) => {
    if(url){
      let response = await getOptions(url);
      setOptionsSelect(response);
    }
    else
      setOptionsSelect(options)  
  }

  const getOptions = async (url) => {
    if(isEnum(url))
      var response = await getEnum(url);
    else
      var response = await api.get(url);

    if(response){
      return response;

      
    }
    else
      return [];
  }

  const isEnum = (url) => {
    return url.endsWith('Enum');
  }

  //Events
  const handleFocus = () => {
    if(loadOnFocus)
      getSelectOptions(url, options)

    setselectPlaceholder(null)
  };

  const handleChange = (event) => {
    const newValue = event.target.value;
    setSelectedValue(newValue);
    if (onChange) {
      onChange(event);
    }
  };

  return (
    <select className={className ?? 'default-select'} value={selectedValue} onChange={handleChange} onFocus={handleFocus}>
      {selectPlaceholder != undefined || selectPlaceholder != null ? <option value="" disabled>{selectPlaceholder}</option> : null}
      {(optionsSelect && optionsSelect.length > 0) ? (
        optionsSelect.map(option => (
        <option key={option.id} value={option.value}>
          {option.description != "" &&  option.description ? option.description : option.label ?? option.value}
        </option>
      ))) : (
        <option value="">Nenhuma opção disponível</option>
      )}
  </select>
  )
}

export default Select