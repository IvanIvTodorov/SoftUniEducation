function extensibleObject() {
    let objProto = Object.getPrototypeOf(this);

    this.extend = function (obj) {
        for (const [key, value] of Object.entries(obj)) {
            if (typeof value == "function") {
                objProto[key] = value;
            } else {
                this[key] = value;
            }
        }
    }
    return this;
};