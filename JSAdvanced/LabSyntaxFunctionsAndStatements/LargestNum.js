function longest(...params) {
    
    let biggest = Math.max(...params);
    console.log(`The largest number is ${biggest}.`);
}

longest(1,2,4);