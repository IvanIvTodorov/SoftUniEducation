function calculator() {
    function calculator(){
        let elementOne = '';
        let elementTwo = '';
        let place = '';
        return {
            init: function (first, second, result){
                elementOne = first.slice(1)
                elementTwo = second.slice(1);
                place = result.slice(1);
            },
            add: function (){
                let a = Number(document.getElementById(elementOne).value);
                let b = Number(document.getElementById(elementTwo).value);
                let result = document.getElementById(place);
    
                result.value = a + b;
            },
            subtract: function(){
                let a = Number(document.getElementById(elementOne).value);
                let b = Number(document.getElementById(elementTwo).value);
                let result = document.getElementById(place);
    
                result.value = a - b;
            }
        }
    }
}




