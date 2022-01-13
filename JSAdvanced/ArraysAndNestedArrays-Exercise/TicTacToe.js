function ticTacToe(moves) {
    function whoIsWinning(win) {
        if (win == "X") {
            console.log("Player X wins!")
            return true;
        }
        if (win == "O") {
            console.log("Player O wins!")
            return true;
        }      
        return false;
    }
    function checkArrWithX(array){
        if (array.every(a => a == "X")) {
            win = "X";
        }
    }
    function checkArrWithO(array){
        if (array.every(a => a == "O")) {
            win = "O";
        }
    }
    let matrix = [
        ["false", "false", "false"],
        ["false", "false", "false"],
        ["false", "false", "false"]
    ];

    let win = "";
    let player = 0;

    for (let start = 0; start < moves.length; start++) {
        let current = moves[start].split(' ');
        let r = current[0];
        let c = current[1];

        if (matrix[r][c] != "false") {
            console.log("This place is already taken. Please choose another!");
            continue;
        }
        
        if (player == 0) {
            matrix[r][c] = "X";
            player = 1;
        } else {
            matrix[r][c] = "O";
            player = 0;
        }

        for (let row = 0; row < matrix.length; row++) {
            checkArrWithX(matrix[row])
            checkArrWithO(matrix[row])
        }
        if (whoIsWinning(win)) {
            break;
        }

        let arrToCheck = [];
        for (let col = 0; col < matrix[0].length; col++) {
            arrToCheck = [];
            for (let row = 0; row < matrix.length; row++) {
                arrToCheck.push(matrix[row][col])
            }
            checkArrWithX(arrToCheck)
            checkArrWithO(arrToCheck)
        }
        if (whoIsWinning(win)) {
            break;
        }
        arrToCheck = []
        let secArrToCheck = [];
        let i = 1;
        for (let index = 0; index < matrix.length; index++) {

            arrToCheck.push(matrix[index][index]);
            secArrToCheck.push(matrix[index][matrix.length - i++]);
        }
        checkArrWithX(arrToCheck)
        checkArrWithO(secArrToCheck)
        checkArrWithX(secArrToCheck)
        checkArrWithO(arrToCheck)
        
        if (whoIsWinning(win)) {
            break;
        }

        if (matrix.flat().every(v => v !== "false")) {
            break;
        }
    }

    if (win == "") {
        console.log("The game ended! Nobody wins :(");
    }
    for (let index = 0; index < matrix.length; index++) {

        console.log(matrix[index].join("\t"));
    }
}

ticTacToe(["0 1",
"0 0",
"0 2", 
"2 0",
"1 0",
"1 1",
"1 2",
"2 2",
"2 1",
"0 0"]
)

ticTacToe(["0 0",
"0 0",
"1 1",
"0 1",
"1 2",
"0 2",
"2 2",
"1 2",
"2 2",
"2 1"]
)

ticTacToe(["0 1",
    "0 0",
    "0 2",
    "2 0",
    "1 0",
    "1 2",
    "1 1",
    "2 1",
    "2 2",
    "0 0"]
)