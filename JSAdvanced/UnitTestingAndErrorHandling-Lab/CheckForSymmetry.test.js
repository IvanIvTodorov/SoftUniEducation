const { isSymmetric } = require('./CheckForSymmetry');
const { expect, assert } = require('chai');
const { describe } = require('mocha');


describe('Check for symmetry', () => {
    it('Receive incorect type', () => {
        assert(isSymmetric({ age: 5, age: 5 }) == false);
    });
    
    
    it('Symmetric array', () => {
        assert(isSymmetric([1, 2, 2, 1]) == true);
    });
    
    
    it('Non symmetric array', () => {
        assert(isSymmetric([1, 2, 1, 1]) == false);
    });

    it('Invalid type', () => {
        assert(isSymmetric([2, 2, '2']) == false);
    });
}); 