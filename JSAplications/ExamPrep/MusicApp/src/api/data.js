import * as api from './api.js';

export const register = api.register;
export const login = api.login;
export const logout = api.logout;


export async function showAll(){
    return api.get('/data/albums?sortBy=_createdOn%20desc&distinct=name');
};

export async function create(data){
    return api.post('/data/albums', data);
};

export async function getById(id){
    return  api.get('/data/albums/' + id);
};

export async function afterSearch(query){
    return api.get(`/data/albums?where=name%20LIKE%20%22${query}%22`);
};

export async function edit(id, data){
    return api.put('/data/albums/' + id , data)
};

export async function onDelete(id){
    return api.del('/data/albums/' + id)
};