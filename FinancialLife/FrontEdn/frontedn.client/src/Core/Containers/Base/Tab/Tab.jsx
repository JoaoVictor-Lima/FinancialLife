import { React, useState} from 'react'
import Panel from '../Panel/Panel'

import './Tab.css'

const Tab = ({tabs, className}) => {
    const [activeTab, setActiveTab] = useState(0);

  return (
    <Panel className='default-tab'>
        <div className='default-tab-list'>
            {tabs.map((tab, index) => (
            <button
                key={index}
                className={`${className ?? 'default-tab-button'} ${activeTab === index ? 'active' : ''}`}
                onClick={() => setActiveTab(index)}
            >
                {tab.label}
            </button>
            ))}
        </div>
        <div className='default-tab-content'>
            {tabs[activeTab].content}
      </div>
    </Panel>
  )
}

export default Tab