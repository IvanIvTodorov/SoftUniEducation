const { expect } = require('chai');
const {isOddOrEven} = require('./EvenOrOdd');

describe('IsOddOrEvenTests', ()=>{
    it('Not a string', () => {
        expect(isOddOrEven(5)).to.be.undefined;
    });

    it('Even string', () =>{
        expect(isOddOrEven('abcd')).to.equal('even');
    });

    it('Odd string', () => {
        expect(isOddOrEven('abc')).to.equal('odd');
    });
})