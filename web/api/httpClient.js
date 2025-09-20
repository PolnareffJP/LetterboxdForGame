// src/services/api.js
import axios from 'axios';

const apiClient = axios.create({
    baseURL: 'https://localhost:5022/api', // Remplace par l'URL de ton API
    withCredentials: false,
    headers: {
        Accept: 'application/json',
        'Content-Type': 'application/json',
    },
});

export default {
    apiClient
};
