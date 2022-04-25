import * as api from './api.js';

export const register = api.register;
export const login = api.login;
export const logout = api.logout;


export async function showAll(){
    return api.get('/data/books?sortBy=_createdOn%20desc');
};

export async function create(data){
    return api.post('/data/books', data);
};

export async function getById(id){
    return  api.get('/data/books/' + id);
};

export async function getYourOwn(userId){
    return api.get(`/data/books?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);
};

export async function edit(id, data){
    return api.put('/data/books/' + id , data)
};

export async function onDelete(id){
    return api.del('/data/books/' + id)
};

export async function likeIt(data){
    return api.post('/data/likes', data)
};

export async function getLikes(bookId){
    return api.get(`/data/likes?where=bookId%3D%22${bookId}%22&distinct=_ownerId&count`)
};

export async function isLiked(bookId, userId){
    return api.get(`/data/likes?where=bookId%3D%22${bookId}%22%20and%20_ownerId%3D%22${userId}%22&count`)
};