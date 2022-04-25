import * as api from './api.js';

export const register = api.register;
export const login = api.login;
export const logout = api.logout;


export async function showAll() {
    return api.get('/data/pets?sortBy=_createdOn%20desc&distinct=name');
};

export async function create(data) {
    return api.post('/data/pets', data);
};

export async function getById(id) {
    return api.get('/data/pets/' + id);
};

export async function getYourOwn(userId) {
    return api.get(`/data/memes?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);
};

export async function edit(id, data) {
    return api.put('/data/pets/' + id, data)
};

export async function onDelete(id) {
    return api.del('/data/pets/' + id)
};

export async function doDonation(data) {
    return api.post(`/data/donation`, data)
};

export async function totalDonations(petId) {
    return api.get(`/data/donation?where=petId%3D%22${petId}%22&distinct=_ownerId&count`)
};

export async function isDonated(petId, userId) {
    return api.get(`/data/donation?where=petId%3D%22${petId}%22%20and%20_ownerId%3D%22${userId}%22&count`)
};