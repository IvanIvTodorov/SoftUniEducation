const host = 'http://localhost:3030';

async function request(url, options) {
    try {
        const res = await fetch(host + url, options);

        if (!res.ok) {
            if (res.status == 403) {
                sessionStorage.clear;
            };

            const er = await res.json();
            throw new Error(er.message);
        };

        if (res.status == 204) {
            return res;
        } else {
            return res.json();
        };

    } catch (error) {
        alert(error.message);
        throw error;
    }
};

function createOptions(method = "get", data) {
    const options = {
        method,
        headers: {}
    };

    if (data != undefined) {
        options.headers['Content-Type'] = 'application/json';
        options.body = JSON.stringify(data);
    };

    let token =  sessionStorage.getItem('token');
    if (token != undefined) {
        options.headers["X-Authorization"] = token;
    };

    return options;
};

export async function get(url) {
    return request(url, createOptions());
};

export async function post(url, data) {
    return request(url, createOptions('post', data));
};

export async function put(url, data) {
    return request(url, createOptions('put', data));
};

export async function del(url) {
    return request(url, createOptions('delete'));
};

export async function login(email, password) {
    let result = await post('/users/login', { email, password });

    console.log(result);
    sessionStorage.setItem('token', result.accessToken);
    sessionStorage.setItem('id', result._id);
    sessionStorage.setItem('email', result.email);
};

export async function register(email, password) {
    const result = await post('/users/register', {email, password });

    let token = result.accessToken;
    let id = result._id;
    let mail = result.email;

    sessionStorage.setItem('token', token);
    sessionStorage.setItem('id', id);
    sessionStorage.setItem('email', mail);
};

export async function logout() {
    await get('/users/logout');
    sessionStorage.clear();
};