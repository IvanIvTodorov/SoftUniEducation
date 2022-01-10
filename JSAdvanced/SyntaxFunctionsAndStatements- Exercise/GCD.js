function GCD(first,second) {
    let number = 0;
    if (first > second) {
        for (let index = 1; index <= first; index++) {
            
            if (first % index == 0 && second % index == 0) {
                number = index;
            }
            
        }
    }else {
        for (let start = 1; start <= second; start++) {
           
            if (first % start == 0 && second % start == 0) {
                number = start;
            }
            
        }
    }

    console.log(number);
}

GCD(2154, 458)
GCD(15,5)