import React, { useState } from 'react';
import api from '../../../Core/Utils/Api/axios';
import getEnum from '../../../Core/Utils/Api/getEnum';

//Style
import './Home.css'

//componens
import Select from '../../../Core/Components/Select/Select';

//pages


//content
import Dashboard from './Dashboard/Dashboard'


const Home = () => {
  
  const [selectedOption, setSelectedOption] = useState('');

  const handleSelectChange = (event) => {
    setSelectedOption(event.target.value);
  };

debugger
  const options = getEnum('ContractEntity.Enums.Core.Uteis.MonthEnum')

  return (
    <div>
      <div>
        João Victor
      </div>
      <div>
      <Select
        options={options}
        value={selectedOption}
        onChange={handleSelectChange}
      />
        Julho
      </div>
      
      <Dashboard/>
    </div>
  )
}

export default Home