import React from 'react'
import QueryPanel from '../../../../Core/Containers/Panels/QueryPanel/QueryPanel'
import Field from '../../../../Core/Components/Field/Field'

import './Dashboard.css'

//Icons
import { MdWallet } from 'react-icons/md'
import { FaArrowAltCircleUp } from "react-icons/fa";
import { FaArrowAltCircleDown } from "react-icons/fa";
import { MdSavings } from "react-icons/md";


const Dashboard = () => {
  return (
    <QueryPanel 
      className='dashboard'
      url={'NaturalPerson/GetAll'}
      fields = {[
        {
          label:"Surplus",
          name:"documentNumber",
          id: "Surplus",
          icon:<MdWallet size={30}/>
        },
        {
          label:"Income",
          value:"R$1650,00",
          name:"Income",
          id: "Income",
          icon:<FaArrowAltCircleUp size={28}/>
        }
      ]}
      >
      {/* //   <h2>Dashboard</h2> 
      //     <Field
      //       label={"Income"}  
      //       value={"R$2000,00"}
      //       icon={<FaArrowAltCircleUp size={28}/>}
      //     />
      //     <Field
      //       label={"Expense"}  
      //       value={"R$1650,00"}
      //       icon={<FaArrowAltCircleDown size={28}/>}
      //     /> 
      //     <Field
      //       label={"Savings"}  
      //       value={"R$1650,00"}
      //       icon={<MdSavings size={30}/>}
      //     />*/}
    </QueryPanel>
  )
}

export default Dashboard