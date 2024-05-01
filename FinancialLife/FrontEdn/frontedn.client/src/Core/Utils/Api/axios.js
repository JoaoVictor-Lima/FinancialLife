import axios from "axios";

const api = axios.create({
    baseURL: "https://localhost:7280/Api/v1/",
    //timeout: 1000,
    headers: {
        "Content-Type": "application/json",
        "Accept": "text/plain",
    },
})

export default api;