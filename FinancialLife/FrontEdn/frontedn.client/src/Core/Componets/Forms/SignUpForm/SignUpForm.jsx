import React from 'react'
import DefaultForm from '../DefaultForm/DefaultForm'

const SignUpForm = (props) => {
    const { url, fields, className } = props;

  return (
    <DefaultForm 
    url={url}
    method="POST"
    fields={fields}
    className={className}
    />
  )
}

export default SignUpForm