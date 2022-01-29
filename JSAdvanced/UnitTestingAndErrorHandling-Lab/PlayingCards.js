function createCard(face, suit){
    let faces = [2, 3, 4, 5, 6, 7, 8, 9, 10, 'J', 'Q', 'K', 'A'];
    let suits = {
        S: "\u2660",
        H: "\u2665",
        D: "\u2666",
        C: "\u2663" 
    }

    if (faces.includes(face) && suits[suit]) {
        return {
            toString() {
                return `${face}${suits[suit]}`;
            }
        }
        
    }else{
        throw new Error('Invalid input !')
    }
}

let temp = createCard('A', 'S');
console.log(temp.toString());