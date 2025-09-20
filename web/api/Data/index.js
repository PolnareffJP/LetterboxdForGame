import httpClient from "../httpClient.js";

export default{
    async getAll(){
        return await httpClient.get("/HomeController");
    }
}