import React from 'react'
import DefaultForm from '../DefaultForm/DefaultForm'

const SignUpForm = (props) => {
    const { url, model, fields, className } = props;

  return (
    <DefaultForm 
    url={url}
    model={model}
    method="POST"
    fields={fields}
    className={className}
    />
  )
}

export default SignUpForm