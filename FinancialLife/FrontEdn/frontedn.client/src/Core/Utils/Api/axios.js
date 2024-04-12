import axios from "axios";

const api = axios.create({
    baseUrl: "https://localhost:5173/",
    timeout: 1000,
    headers: {'x-custom-Header': 'footbar'}
})

export default api;