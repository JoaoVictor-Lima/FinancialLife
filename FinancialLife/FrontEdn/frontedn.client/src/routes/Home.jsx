import axios from 'axios';

import {useState, useEffect} from 'react';
import { Link } from 'react-router-dom';

const Home = () => {
  const [pessoa, setPessoa] = useState([]);

  const getPessoa = async() => {
    try {
      const response = await axios.get("https://localhost:7280/api/v1/Pessoa/GetAllPessoas");
      console.log(response);
      const data = response.data;
      setPessoa(data);
    } catch (error) {
      
    }
  };

  useEffect(() => {
    getPessoa();
  }, []);

  return (
    <div>Teste inicial</div>
  )
}

export default Home