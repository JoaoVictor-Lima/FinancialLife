import React, { useState } from 'react';

//Style
import './Home.css'

//componens
import Select from '../../../Core/Components/Select/Select';

//pages


//content
import Dashboard from './Dashboard/Dashboard'


const Home = () => {

  return (
    <div>
      <div>
        João Victor
      </div>
      <div>
      <Select
        url={'FinancialLifeDomain/Enums/MonthEnum'}
      />
      </div>
      
      <Dashboard/>
    </div>
  )
}

export default Home