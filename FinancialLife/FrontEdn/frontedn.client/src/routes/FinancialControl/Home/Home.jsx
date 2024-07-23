import React, { useState } from 'react';
import Panel from '../../../Core/Containers/Base/Panel/Panel';

//Style
import './Home.css'

//componens
import Select from '../../../Core/Components/Select/Select';

//pages


//content
import Dashboard from './Dashboard/Dashboard'
import Tab from '../../../Core/Containers/Base/Tab/Tab';

const tabs = [
  {
    label: 'Dashboard',
    content: <Dashboard/>,
  },
  {
    label: 'Income',
    content: <div>Content for Tab 2</div>,
  },
  {
    label: 'Expense',
    content: <div>Content for Tab 3</div>,
  },
  {
    label: 'Savings',
    content: <div>Content for Tab 3</div>,
  },
];


const Home = () => {

  return (
    <Panel>
      <div className='user-information'>
        João Victor
      </div>
      <div className='month-select'>
      <Select
        url={'FinancialLifeDomain/Enums/MonthEnum'}
      />
      </div>
      <Tab
        tabs={tabs}
      />
    </Panel>
  )
}

export default Home