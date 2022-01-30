const { lookupChar } = require('./CharLookup');
const { expect } = require('chai');

describe('CharLookup Tests', () => {
    it('Invalid first parameter', () => {
        expect(lookupChar(5, 5)).to.be.undefined;
    });

    it('Invalid second parameter', () => {
        expect(lookupChar('test', 'Test')).to.be.undefined;
    });

    it('Invalid first and second parameter', () => {
        expect(lookupChar(5, 'Test')).to.be.undefined;
    });
    it('Number not an integer', () => {
        expect(lookupChar('test', 0.1)).to.be.undefined;
    });

    it('Number bigger than string size', () => {
        expect(lookupChar('a', 1)).to.equal('Incorrect index');
    })

    it('Number bigger than string size', () => {
        expect(lookupChar('a', 100)).to.equal('Incorrect index');
    })

    it('Negative number',() => {
        expect(lookupChar('a', -1)).to.equal('Incorrect index');
    });

    it('Works Prorpely',() => {
        expect(lookupChar('iamrich', 0)).to.equal('i');
    });

    it('Works Prorpely',() => {
        expect(lookupChar('return', 5)).to.equal('n');
    });
});