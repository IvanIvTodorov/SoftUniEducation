const {StringBuilder} = require('./StringBuilder');
const { expect } = require('chai');

describe('StringBuilderTest', () => {
    let testUndefind;
    let test;

    beforeEach(() => {
        test = new StringBuilder('az');
        testUndefind = new StringBuilder(undefined);
    });

    it('TestUndefined', () => {
        expect(testUndefind._stringArray).to.be.empty;
    });

    it('Test with string', () => {
        expect(test._stringArray).to.deep.equal(['a', 'z']);
    });

    it('Test constructor throws exception', () => {
        expect(() => {
            new StringBuilder(5);
        }).to.throw('Argument must be a string');
    });

    it('Test methods', () => {
        testUndefind.append('a');
        expect(testUndefind._stringArray).to.deep.equal(['a']);
        testUndefind.prepend('b');
        expect(testUndefind._stringArray).to.deep.equal(['b', 'a']);
        testUndefind.insertAt('abc', 1);
        expect(testUndefind._stringArray).to.deep.equal(['b', 'a', 'b' ,'c', 'a']);
        testUndefind.remove(1, 3);
        expect(testUndefind._stringArray).to.deep.equal(['b',  'a']);
        expect(testUndefind.toString()).to.eq('ba');

        expect(() => {
            testUndefind.append(5);
        }).to.throw('Argument must be a string');
        expect(() => {
            testUndefind.prepend(5);
        }).to.throw('Argument must be a string');
        expect(() => {
            testUndefind.insertAt(5,5);
        }).to.throw('Argument must be a string');
        
    })
})