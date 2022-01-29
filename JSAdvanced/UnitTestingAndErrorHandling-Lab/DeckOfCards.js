function printDeckOfCards(cards) {
    let arr = [];

    for (const card of cards) {
        let face = card.slice(0, -1);
        let suit = card.slice(-1);

        try {
            arr.push(createCard(face, suit).toString());
        } catch (error) {
            return console.log(`Invalid card: ${card}`);
        }
    }

    console.log(arr);

    function createCard(face, suit) {
        let faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
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

        } else {
            throw new Error('Invalid input !')
        }
    }
}

printDeckOfCards(['AS', '10D', 'KH', '1C']);
