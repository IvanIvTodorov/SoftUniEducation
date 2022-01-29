const { rgbToHexColor } = require('./RGBToHEX');
const { expect, assert } = require('chai');

describe('RGB TEST', () => {
    it('invalid red type', () => {
        expect(rgbToHexColor(-1, 2, 3)).to.be.undefined;
    });

    it('invalid red type', () => {
        expect(rgbToHexColor(256, 2, 3)).to.be.undefined;
    });

    it('invalid red type', () => {
        expect(rgbToHexColor('a', 2, 3)).to.be.undefined;
    });

    it('invalid green type', () => {
        expect(rgbToHexColor(1, -2, 3)).to.be.undefined
    });

    it('invalid green type', () => {
        expect(rgbToHexColor(1, 256, 3)).to.be.undefined
    });

    it('invalid green type', () => {
        expect(rgbToHexColor(1, 'a', 3)).to.be.undefined
    });

    it('invalid blue type', () => {
        expect(rgbToHexColor(1, 2, -3)).to.be.undefined
    });

    it('invalid blue type', () => {
        expect(rgbToHexColor(1, 2, 256)).to.be.undefined
    });

    it('invalid blue type', () => {
        expect(rgbToHexColor(1, 5, 'a')).to.be.undefined
    });

    it('Equal color', () => {
        expect(rgbToHexColor(2, 4, 6)).to.equal('#020406');
    })

    it("Return valid hex", function () {
        assert((rgbToHexColor(2, 255, 255).length == 7));
    });

    it("Return valid hex", function () {
        assert((rgbToHexColor(255, 255, 255) == '#FFFFFF'));
    });
    it("Return valid hex", function () {
        assert((rgbToHexColor(0, 0, 0) == '#000000'));
    });
});