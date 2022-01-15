function transform(arr){

    const result = {};

    for (let index = 0; index < arr.length; index+= 2) {
        
        result[arr[index]] = Number(arr[index + 1]);
        
    }

    return result;
}

console.log(transform(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']));