function checkAll(number) {
    
   
    let flag = true;
    let sum = 0;
    let myString = number.toString();
    let symbol = myString[0];
    
    for (let index = 0; index < myString.length; index++) {
        if (myString[index] != symbol) {
            flag = false;   
        }
        
        sum += Number(myString[index]);
    }

    console.log(flag);
    console.log(sum);
}

checkAll(2222222)
checkAll(1234)