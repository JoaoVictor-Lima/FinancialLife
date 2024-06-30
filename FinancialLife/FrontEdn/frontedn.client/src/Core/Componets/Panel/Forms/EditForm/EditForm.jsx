import React from 'react'
import DefaultForm from '../DefaultForm/DefaultForm'

const EditForm = (props) => {
    const { url, fields, className } = props;

  return (
    <DefaultForm 
    url={url}
    method="PUT"
    fields={fields}
    className={className}
    />
  )
}

export default EditForm