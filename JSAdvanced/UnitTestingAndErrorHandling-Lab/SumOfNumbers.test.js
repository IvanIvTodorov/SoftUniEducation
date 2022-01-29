const { expect, assert } = require('chai');
const { sum } = require('./SumOfNumbers');

describe('SumOfNumbers tests', () => {
    it('To equal 6', () => {
        expect(sum([1, 2, 3])).to.equal(6);
    });

    it('To be different ', () => {
        assert(sum([1, 2, 3]) != 2);
    });
});