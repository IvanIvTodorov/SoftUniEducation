import * as api from './api.js';

export const register = api.register;
export const login = api.login;
export const logout = api.logout;


export async function showAll(){
    return api.get('/data/memes?sortBy=_createdOn%20desc');
};

export async function create(data){
    return api.post('/data/memes', data);
};

export async function getById(id){
    return  api.get('/data/memes/' + id);
};

export async function getYourOwn(userId){
    return api.get(`/data/memes?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);
};

export async function edit(id, data){
    return api.put('/data/memes/' + id , data)
};

export async function onDelete(id){
    return api.del('/data/memes/' + id)
};