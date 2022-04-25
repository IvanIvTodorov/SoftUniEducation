import * as api from './api.js';

export const register = api.register;
export const login = api.login;
export const logout = api.logout;


export async function showAll() {
    return api.get('/data/games?sortBy=_createdOn%20desc');
};

export async function create(data) {
    return api.post('/data/games', data);
};

export async function getById(id) {
    return api.get('/data/games/' + id);
};

export async function getYourOwn(userId) {
    return api.get(`/data/memes?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);
};

export async function edit(id, data) {
    return api.put('/data/games/' + id, data)
};

export async function onDelete(id) {
    return api.del('/data/games/' + id)
};

export async function getRecentGames() {
    return api.get('/data/games?sortBy=_createdOn%20desc&distinct=category')
};

export async function getComments(gameId){
    return api.get(`/data/comments?where=gameId%3D%22${gameId}%22`)
};

export async function createComment(data){
    return api.post(`/data/comments`, data)
};