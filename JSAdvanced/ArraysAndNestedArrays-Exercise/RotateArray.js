function rotateArray(input, times){

    for (let index = 0; index < times; index++) {
        input.unshift(input.pop());    
    }
    
    console.log(input.join(' '));
}

rotateArray(['1', 
'2', 
'3', 
'4'], 
2
)
rotateArray(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
)