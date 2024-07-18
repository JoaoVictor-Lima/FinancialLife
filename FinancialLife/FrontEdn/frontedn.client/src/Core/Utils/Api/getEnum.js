import api from './axios'; 

const getEnum = async (enumType) => {
  try {
    const response = await api.get('Enum/GetEnumValues', {
      params: { enumType }
    });
    return response.data;
  } catch (error) {
    console.error(`Erro ao buscar enum ${enumType}:`, error);
    return [];
  }
};

export default getEnum;