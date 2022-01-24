function solve(area, vol, input) {
    let elements = JSON.parse(input);
    let output = [];
    
    for (const element of elements) {

        output.push({
            area: area.apply(element),
            volume: vol.apply(element)
        })
    }
    return output;
};

function area() {
    return Math.abs(this.x * this.y);
};

function vol() {
    return Math.abs(this.x * this.y * this.z);
};

console.log(solve(area, vol, `[
    {"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}
    ]`
    ));