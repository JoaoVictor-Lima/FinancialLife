import React, { useState, useEffect } from 'react'
import api from '../../Utils/Api/axios'

const Select = ({options, value, onChange, placeholder, className, url, loadOnFocus }) => {

  //States
  const [dataOptions, setDataOptions] = useState([]);
  const [getRealized, setGetRealized] = useState(false);

  //Effect
  useEffect(() => {
    if (url && !loadOnFocus && !getRealized) {
      getOptions(url);
      setGetRealized(true);
    }
  }, [url, loadOnFocus, getRealized]);


  //Logic
  const getOptions = async (url) => {
    try {
      let response = await api.get(url)
      setDataOptions(response.data);
    } catch (error) { 
      console.log(error);
      setDataOptions([]);
    }
  }

  //Events
  const handleFocus = () => {
    if (url && loadOnFocus && !getRealized) {
      getOptions(url);
      setGetRealized(true);
    }
  };

  const optionsSelection = url ? dataOptions : options ?? []
  debugger
  
  return (
    <select className={className} value={value} onChange={onChange} onFocus={handleFocus}>
      {placeholder != undefined ? <option value="" disabled>{placeholder}</option> : null}
      {optionsSelection.map((option) => (
        <option key={option.value} value={option.value}>
          {option.label}
        </option>
      ))}
  </select>
  )
}

export default Select