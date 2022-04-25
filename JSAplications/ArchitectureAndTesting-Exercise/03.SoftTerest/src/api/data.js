import * as api from './api.js';

export const login = api.login;
export const register = api.register;
export const logout = api.logout;

export async function showAll(){
    return api.get('/data/ideas?select=_id%2Ctitle%2Cimg&sortBy=_createdOn%20desc');
};

export async function getByID(id){
    return api.get('/data/ideas/' + id);
};

export async function create(obj){
    return api.post('/data/ideas', obj);
};

export async function del(id){
    return api.del('/data/ideas/' + id);
};