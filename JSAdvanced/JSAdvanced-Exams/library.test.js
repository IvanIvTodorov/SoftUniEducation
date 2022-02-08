const library = require('./library')
const { expect } = require('chai');
const { arrangeTheBooks } = require('./library');


describe('Library Tests', () => {
    describe('CalcPriceTest', () => {

        it('Works ok', () => {
            expect(library.calcPriceOfBook('Ivan', 1997)).to.eq(`Price of Ivan is 20.00`);
        });

        it('Works ok', () => {
            expect(library.calcPriceOfBook('Ivan', 1980)).to.eq(`Price of Ivan is 10.00`);
        });

        it('Throws error', () => {
            expect(() => {
                library.calcPriceOfBook(5, 1997);
            }).to.throw('Invalid input');
        });

        it('Throws error', () => {
            expect(() => {
                library.calcPriceOfBook("A", 2.2);
            }).to.throw('Invalid input');
        })

    });

    describe('FindBook Tests', () => {
        it('Thorws error', () => {
            expect(() => {
                library.findBook([], 'Ivan');
            }).to.throw('No books currently available');
        });

        it('No Book Here', () => {
            expect(library.findBook(['Jhon'], 'Ivan')).to.eq('The book you are looking for is not here!');
        });

        it('No Book Here', () => {

            expect(library.findBook(['Ivan'], 'Ivan')).to.eq('We found the book you want.');
        });
    });

    describe('ArrangeTheBooks tests', () => {
        it('Throws error', () => {
            expect(() => {
                library.arrangeTheBooks(2.2);
            }).to.throw('Invalid input');
        });

        it('Throws error', () => {
            expect(() => {
                library.arrangeTheBooks(-1);
            }).to.throw('Invalid input');
        });

        it('Works ok', () => {
            expect(library.arrangeTheBooks(5)).to.eq('Great job, the books are arranged.');
        });

        it('Works ok', () => {
            expect(library.arrangeTheBooks(40)).to.eq('Great job, the books are arranged.');
        });

        it('Works ok', () => {
            expect(library.arrangeTheBooks(41)).to.eq('Insufficient space, more shelves need to be purchased.');
        });
    });
});