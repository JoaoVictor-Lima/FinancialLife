import React, { useState } from 'react';
import DefaultForm from '../DefaultForm/DefaultForm'

const SignUpForm = (props) => {
    const { url, model, fields, className } = props;
    const [responseData, setResponseData] = useState({});

  return (
    <DefaultForm 
    url={url}
    model={model}
    method="POST"
    fields={fields}
    className={className}
    onSuccess={setResponseData}
    />
  )
}

export default SignUpForm