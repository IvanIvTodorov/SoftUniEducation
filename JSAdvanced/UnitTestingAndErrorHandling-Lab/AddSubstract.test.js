const { createCalculator } = require('./AddSubstract');
const { assert, expect } = require('chai');

describe('Calc Tests', () => {
    let temp = null;

    beforeEach(function () {
        temp = createCalculator();
    })

    it('add', () => {
        expect(temp).to.have.property('add');
    });
    it('subtract', () => {
        expect(temp).to.have.property('subtract');
    });
    it('get', () => {
        expect(temp).to.have.property('get');
    });

    it('calculate', () => {
        temp.add('5');
        temp.add(2);
        expect(temp.get()).to.equal(7);
    })
    it('calculate', () => {
        temp.subtract('5');
        temp.subtract('2');
        expect(temp.get()).to.equal(-7);
    })
    it('calculate', () => {
        temp.add(5);
        temp.subtract(6);
        expect(temp.get()).to.equal(-1);
    })
    it('calculate', () => {
        temp.add(5);
        temp.subtract('4');
        expect(temp.get()).to.equal(1);
    })
});