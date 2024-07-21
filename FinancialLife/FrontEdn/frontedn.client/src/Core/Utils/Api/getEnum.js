import api from './axios'; 

const getEnum = async (url) => {
  try {
    const response = await api.get('Enum/GetEnum', {
      params: { url }
    });
    return response.data;
  } catch (error) {
    console.error(`Erro ao buscar enum ${enumType}:`, error);
    return [];
  }
};

export default getEnum;