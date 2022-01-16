function rectangle(...params) {
    let [width, height, color] = params;

    const rectFactory = {
        width,
        height,
        color: color.replace(color.charAt(0), color.charAt(0).toUpperCase()),
        calcArea: function () {
            return this.width * this.height;
        }
    }
    return rectFactory;
}

let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
