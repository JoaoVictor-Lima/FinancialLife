import axios from "axios";

const api = axios.create({
    baseURL: "https://localhost:7280/",
    timeout: 1000,
    headers: {'x-custom-Header': 'footbar'}
})

export default api;