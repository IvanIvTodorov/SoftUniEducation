const { dealership } = require('./dealership');
const { expect } = require('chai');

describe('Dealership Tests', () => {
    describe('NewCarCost tests', () => {
        it('test final price', () => {
            expect(dealership.newCarCost('Audi A4 B8', 20000)).to.eq(5000);
        });

        it('test new price', () => {
            expect(dealership.newCarCost('Audi A4 ', 20000)).to.eq(20000);
        });
    });

    describe('CarEquipment tests', () => {
        it('works prop', () => {
            expect(dealership.carEquipment(['a', 'b'], [0, 1])).to.deep.equal(['a','b']);
        })

        it('works prop', () => {
            expect(dealership.carEquipment(['a', 'b', 'c'], [0, 1])).to.deep.equal(['a','b']);
        })
    });

    describe('Eurocategory', () => {
        it('Even or bigger than 4', () => {
            expect(dealership.euroCategory(4)).to.eq(`We have added 5% discount to the final price: 14250.`);
        });

        it('Smaller than 4', () => {
            expect(dealership.euroCategory(3)).to.eq(`Your euro category is low, so there is no discount from the final price!`);
        });
    });
});