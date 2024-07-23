import React from 'react'
import Panel from '../../../../Core/Containers/Base/Panel/Panel'
import Field from '../../../../Core/Components/Field/Field'

import './Dashboard.css'

//Icons
import { MdWallet } from 'react-icons/md'
import { FaArrowAltCircleUp } from "react-icons/fa";
import { FaArrowAltCircleDown } from "react-icons/fa";
import { MdSavings } from "react-icons/md";


const Dashboard = () => {
  return (
    <Panel className='dashboard'>
        <h2>Dashboard</h2>
        <Field
          label={"Surplus"}  
          value={"R$1650,00"}
          icon={<MdWallet/>}
        />
        <Field
          label={"Income"}  
          value={"R$1650,00"}
          icon={<FaArrowAltCircleUp/>}
        />
        <Field
          label={"Expense"}  
          value={"R$1650,00"}
          icon={<FaArrowAltCircleDown/>}
        /> 
        <Field
          label={"Savings"}  
          value={"R$1650,00"}
          icon={<MdSavings/>}
        />
    </Panel>
  )
}

export default Dashboard