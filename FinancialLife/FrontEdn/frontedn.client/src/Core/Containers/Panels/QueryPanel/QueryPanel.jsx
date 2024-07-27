import React, { useEffect, useState, useRef } from 'react'
import Panel from '../../Base/Panel/Panel'
import api from '../../../Utils/Api/axios';
import Field from '../../../Components/Field/Field';

const QueryPanel = ({className, fields, url}) => {

    const [data, setData] = useState(null)
    const me = useRef(null);
    const fieldsRef = useRef([]);

    useEffect(() => {
        executeQuery(url);
    },[url]);

    const executeQuery = async (url) => {
        let response = await api.get(url);
        setData(response.data);
        renderDataInChields(response.data);
    }

    const getPropertyNames = (obj) => {
        return Object.keys(obj);
    };

    const renderDataInChields = (data) => {
        fieldsRef.current.forEach(field => {
            data.forEach(x => {
                const properties = getPropertyNames(x);
                properties.forEach(y => {
                    if(y == field.getName()){
                        field.setValue(x[y]);
                    }
                })
            })
          });
    };


  return (
    <Panel 
        className={className ?? 'default-query-panel'}
        ref={me}
        >
        {fields.map(((field, index) => (
            <Field
                key={field.id}
                className={field.className ?? 'default-field'}
                name={field.name}
                id={field.id}
                value={field.value}
                label={field.label}
                icon={field.icon}
                ref={el => (fieldsRef.current[index] = el)}
            />
        )))}
    </Panel>
  )
}

export default QueryPanel