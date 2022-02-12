const {numberOperations} = require('./numberOperations');
const { expect } = require('chai');

describe('NumberOperationsTests', () => {
    describe('PowNum tests', () => {
        it('Works prop', () =>{
            expect(numberOperations.powNumber(2)).to.eq(4);
        });
    });

    describe('NumberChecker Tests', () => {
        it('Throws error', () => {
            expect(() =>{
                numberOperations.numberChecker('a')
            }).to.throw('The input is not a number!');
        });

        it('Smaller than 100', () => {
            expect(numberOperations.numberChecker(99)).to.eq('The number is lower than 100!');
        });

        it('Bigger than 100', () => {
            expect(numberOperations.numberChecker(100)).to.eq('The number is greater or equal to 100!');
        });

        it('Bigger than 101', () => {
            expect(numberOperations.numberChecker(100)).to.eq('The number is greater or equal to 100!');
        });
    });

    describe('SumArrays Tests', () => {
        it('Works prop', () => {
            expect(numberOperations.sumArrays([1],[1])).to.deep.equal([2]);
        });

        it('Works prop', () => {
            expect(numberOperations.sumArrays([1,2,3],[1,2])).to.deep.equal([2,4,3]);
        });

        it('Works prop', () => {
            expect(numberOperations.sumArrays([1],[1,2])).to.deep.equal([2,2]);
        });
    });
});