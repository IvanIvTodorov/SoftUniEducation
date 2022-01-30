function validator(obj) {
    const method = {
        GET: 'GET',
        POST: 'POST',
        DELETE: 'DELETE',
        CONNECT: 'CONNECT'
    }

    const version = {
        ['HTTP/0.9']: 'HTTP/0.9',
        ['HTTP/1.0']: 'HTTP/1.0',
        ['HTTP/1.1']: 'HTTP/1.1',
        ['HTTP/2.0']: 'HTTP/2.0'
    }

    let uriTest = /^([a-zA-Z0-9\.]+|\*)$/;
    let msgTest = /^[^<>\\&'"]*$/;

    if (!Object.keys(method).includes(obj.method)) {
        throw new Error(`Invalid request header: Invalid Method`);
    };

    if (!uriTest.test(obj.uri) || obj.uri == undefined) {
        throw new Error(`Invalid request header: Invalid URI`);
    };

    if (!Object.keys(version).includes(obj.version)) {
        throw new Error(`Invalid request header: Invalid Version`);
    };

    if (!msgTest.test(obj.message) || obj.message == undefined) {
        if (obj.message == '') {
            return obj;
        };
        throw new Error(`Invalid request header: Invalid Message`);
    };

    return obj;
}

console.log(validator({
    method: 'GET',
    uri: '(***)',
    version: 'HTTP/5.1',
    message: ''
}
));

//   console.log(validator({
//     method: 'OPTIONS',
//     uri: 'git.master',
//     version: 'HTTP/1.1',
//     message: '-recursive'
//   }
//   ));

//   console.log(validator({
//     method: 'POST',
//     uri: 'home.bash',
//     message: 'rm -rf /*'
//   }
//   ));