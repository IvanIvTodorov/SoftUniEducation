import * as api from './api.js';

export const register = api.register;
export const login = api.login;
export const logout = api.logout;


export async function showAll(){
    return api.get('/data/theaters?sortBy=_createdOn%20desc&distinct=title');
};

export async function create(data){
    return api.post('/data/theaters', data);
};

export async function getById(id){
    return  api.get('/data/theaters/' + id);
};

export async function getYourOwn(userId){
    return api.get(`/data/theaters?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);
};

export async function edit(id, data){
    return api.put('/data/theaters/' + id , data)
};

export async function onDelete(id){
    return api.del('/data/theaters/' + id)
};

export async function likeIt(data){
    return api.post('/data/likes', data)
};

export async function totalLikes(theaterId){
    return api.get(`/data/likes?where=theaterId%3D%22${theaterId}%22&distinct=_ownerId&count`);
};

export async function isLiked(theaterId, userId){
    return api.get(`/data/likes?where=theaterId%3D%22${theaterId}%22%20and%20_ownerId%3D%22${userId}%22&count`)
};